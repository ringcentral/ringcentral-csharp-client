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
    public partial class SubscriptionPath
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
                return new
                {
                    eventFilters = EventFilters,
                    deliveryMode = new { transportType = "PubNub", encryption = true }
                };
            }
        }

        private RestClient rc;
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
                if (_subscriptionInfo != null && !renewScheduled)
                {
                    Task.Delay((int)(_subscriptionInfo.expiresIn.Value - 120) * 1000).ContinueWith(async (action) =>
                    { // 2 minutes before expiration
                            renewScheduled = false;
                        await Renew();
                    });
                    renewScheduled = true;
                }
            }
        }

        internal SubscriptionService(RestClient rc)
        {
            this.rc = rc;
        }

        public async Task<bool> Register()
        {
            if (!Alive())
            {
                return await Subscribe();
            }
            else
            {
                return await Renew();
            }
        }

        private async Task<bool> Subscribe()
        {
            var temp = await rc.Restapi().Subscription().Post(requestBody);
            subscriptionInfo = JsonConvert.DeserializeObject<SubscriptionInfo>(JsonConvert.SerializeObject(temp));
            pubnub = new Pubnub(null, subscriptionInfo.deliveryMode.subscriberKey);
            pubnub.Subscribe<string>(subscriptionInfo.deliveryMode.address, OnSubscribe, OnConnect, OnError);
            return true;
        }

        public async Task<bool> Renew()
        {
            if (!Alive())
            { // Remove() has been called
                return false;
            }
            try
            {
                var response = await rc.Restapi().Subscription(subscriptionInfo.id).Put(requestBody);
                subscriptionInfo = JsonConvert.DeserializeObject<SubscriptionInfo>(JsonConvert.SerializeObject(response));
                return true;
            }
            catch (FlurlHttpException fhe)
            {
                if (fhe.Call.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                { // subscription not found on server side
                    return await Subscribe();
                }
                throw fhe;
            }
        }

        public async Task<bool> Remove()
        {
            if (!Alive())
            { // has been removed
                return true;
            }
            var temp = await rc.Restapi().Subscription(subscriptionInfo.id).Delete();
            subscriptionInfo = null;
            pubnub = null;
            return true;
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