using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using PubNubMessaging.Core;
using RingCentral.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral.Subscription
{
    public class SubscriptionEventArgs : EventArgs
    {
        public object Message { get; private set; }
        public SubscriptionEventArgs(object message)
        {
            Message = message;
        }
    }

    public class SubscriptionService
    {
        public event EventHandler<SubscriptionEventArgs> NotificationEvent;
        public event EventHandler<SubscriptionEventArgs> ConnectEvent;
        public event EventHandler<SubscriptionEventArgs> ErrorEvent;
        public List<string> EventFilters { get; set; } = new List<string>();
        private string requestBody
        {
            get
            {
                return JsonConvert.SerializeObject(new
                {
                    eventFilters = EventFilters,
                    deliveryMode = new { transportType = "PubNub", encryption = true }
                });
            }
        }

        private Platform platform;
        private Pubnub pubnub;
        private SubscriptionInfo _subscriptionInfo;
        private bool renewScheduled = false;
        private SubscriptionInfo subscriptionInfo
        {
            get
            {
                return _subscriptionInfo;
            }
            set
            {
                _subscriptionInfo = value;
                if (_subscriptionInfo != null)
                {
                    if (!renewScheduled)
                    { // don't do duplicate schedule
                        TaskEx.Delay((_subscriptionInfo.ExpiresIn - 120) * 1000).ContinueWith((action) =>
                        { // 2 minutes before expiration
                            renewScheduled = false;
                            Renew();
                        });
                        renewScheduled = true;
                    }
                }
            }
        }

        internal SubscriptionService(Platform platform)
        {
            this.platform = platform;
        }

        public void Register()
        {
            if (!Alive())
            {
                Subscribe();
            }
            else
            {
                Renew();
            }
        }

        private void Subscribe()
        {
            var request = new Request("/restapi/v1.0/subscription", requestBody);
            var response = platform.Post(request);
            subscriptionInfo = JsonConvert.DeserializeObject<SubscriptionInfo>(response.Body);
            pubnub = new Pubnub(null, subscriptionInfo.DeliveryMode.SubscriberKey);
            pubnub.Subscribe<string>(subscriptionInfo.DeliveryMode.Address, OnSubscribe, OnConnect, OnError);
        }

        private void Renew()
        {
            if (!Alive())
            { // Remove() has been called
                return;
            }
            var request = new Request("/restapi/v1.0/subscription/" + subscriptionInfo.Id, requestBody);
            ApiResponse response = null;
            try
            {
                response = platform.Put(request);
            }
            catch (ApiException ae)
            {
                if (ae.Response.Status == 404)
                { // subscription not found on server side
                    Subscribe();
                    return;
                }
                throw ae;
            }
            subscriptionInfo = JsonConvert.DeserializeObject<SubscriptionInfo>(response.Body);
        }

        public void Remove()
        {
            if (!Alive())
            { // has been removed
                return;
            }
            var request = new Request("/restapi/v1.0/subscription/" + subscriptionInfo.Id);
            var response = platform.Delete(request);
            subscriptionInfo = null;
            pubnub = null;
        }

        public bool Alive()
        {
            return pubnub != null && subscriptionInfo != null && subscriptionInfo.Id != null && subscriptionInfo.DeliveryMode != null
                && subscriptionInfo.DeliveryMode.SubscriberKey != null && subscriptionInfo.DeliveryMode.Address != null;
        }

        private void OnSubscribe(string result)
        {
            var message = JsonConvert.DeserializeObject<string[]>(result)[0];
            NotificationEvent?.Invoke(this, new SubscriptionEventArgs(Decrypt(message)));
        }

        private void OnConnect(string connectMessage)
        {
            ConnectEvent?.Invoke(this, new SubscriptionEventArgs(connectMessage));
        }

        private void OnError(PubnubClientError pubnubError)
        {
            ErrorEvent?.Invoke(this, new SubscriptionEventArgs(pubnubError));
        }

        private object Decrypt(string dataString)
        {
            var key = Convert.FromBase64String(subscriptionInfo.DeliveryMode.EncryptionKey);
            var keyParameter = ParameterUtilities.CreateKeyParameter("AES", key);
            var cipher = CipherUtilities.GetCipher("AES/ECB/PKCS7Padding");
            cipher.Init(false, keyParameter);

            var data = Convert.FromBase64String(dataString);
            var memoryStream = new MemoryStream(data, false);
            var cipherStream = new CipherStream(memoryStream, cipher, null);

            var bufferSize = 1024;
            var buffer = new byte[bufferSize];
            var length = 0;
            var resultStream = new MemoryStream();
            while ((length = cipherStream.Read(buffer, 0, bufferSize)) > 0)
            {
                resultStream.Write(buffer, 0, length);
            }
            var resultBytes = resultStream.ToArray();
            var result = Encoding.UTF8.GetString(resultBytes, 0, resultBytes.Length);
            return JsonConvert.DeserializeObject(result);
        }
    }
}