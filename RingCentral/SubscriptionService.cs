using Flurl.Http;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using PubNubMessaging.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Subscription
    {
        public SubscriptionService New()
        {
            return new SubscriptionService(RC);
        }
    }

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
        private object requestBody
        {
            get
            {
                return new {
                    eventFilters = EventFilters,
                    deliveryMode = new { transportType = "PubNub", encryption = true }
                };
            }
        }

        private RestClient rc;
        private Pubnub pubnub;
        private Subscription.GetResponse _subscriptionInfo;
        private bool renewScheduled = false;
        private Subscription.GetResponse subscriptionInfo
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
                        Task.Delay((_subscriptionInfo.expiresIn.Value - 120) * 1000).ContinueWith((action) =>
                        { // 2 minutes before expiration
                            renewScheduled = false;
                            Renew();
                        });
                        renewScheduled = true;
                    }
                }
            }
        }

        internal SubscriptionService(RestClient rc)
        {
            this.rc = rc;
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
            var temp = rc.Restapi().Subscription().Post(requestBody).Result;
            subscriptionInfo = JsonConvert.DeserializeObject<Subscription.GetResponse>(JsonConvert.SerializeObject(temp));
            pubnub = new Pubnub(null, subscriptionInfo.deliveryMode.subscriberKey);
            pubnub.Subscribe<string>(subscriptionInfo.deliveryMode.address, OnSubscribe, OnConnect, OnError);
        }

        private void Renew()
        {
            if (!Alive())
            { // Remove() has been called
                return;
            }
            try
            {
                var response = rc.Restapi().Subscription(subscriptionInfo.id).Put(requestBody).Result;
                subscriptionInfo = JsonConvert.DeserializeObject<Subscription.GetResponse>(JsonConvert.SerializeObject(response));
            }
            catch (FlurlHttpException fhe)
            {
                if (fhe.Call.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                { // subscription not found on server side
                    Subscribe();
                    return;
                }
                throw fhe;
            }
        }

        public void Remove()
        {
            if (!Alive())
            { // has been removed
                return;
            }
            var temp = rc.Restapi().Subscription(subscriptionInfo.id).Delete().Result;
            subscriptionInfo = null;
            pubnub = null;
        }

        public bool Alive()
        {
            return pubnub != null && subscriptionInfo != null && subscriptionInfo.id != null && subscriptionInfo.deliveryMode != null
                && subscriptionInfo.deliveryMode.subscriberKey != null && subscriptionInfo.deliveryMode.address != null;
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
            var key = Convert.FromBase64String(subscriptionInfo.deliveryMode.encryptionKey);
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