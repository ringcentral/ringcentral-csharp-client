using Flurl.Http;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using PubnubApi;
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
    public class NotificatioEventArgs : EventArgs
    {
        public string message { get; private set; }
        public NotificatioEventArgs(string message)
        {
            this.message = message;
        }
    }

    public class SubscriptionService
    {
        public event EventHandler<NotificatioEventArgs> NotificationEvent;
        public event EventHandler<SubscriptionEventArgs> PresenceEvent;
        public event EventHandler<SubscriptionEventArgs> StatusEvent;
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
        public SubscriptionInfo subscriptionInfo
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
            var pnConfig = new PNConfiguration();
            pnConfig.SubscribeKey = subscriptionInfo.deliveryMode.subscriberKey;
            pubnub = new Pubnub(pnConfig);
            pubnub.AddListener(new SubscribeCallbackExt(
                (pubnubObj, message) => {
                    NotificationEvent?.Invoke(this, new NotificatioEventArgs(Decrypt(message.Message.ToString())));
                }, 
                (pubnubObj, presence) => {
                    PresenceEvent?.Invoke(this, new SubscriptionEventArgs(presence));
                }, 
                (pubnubObj, status) => {
                    StatusEvent?.Invoke(this, new SubscriptionEventArgs(status));
                }
            ));
            pubnub.Subscribe<string>().Channels(new string[] {
                subscriptionInfo.deliveryMode.address
            }).Execute();
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

        private string Decrypt(string dataString)
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
            return Encoding.UTF8.GetString(resultBytes, 0, resultBytes.Length);
        }
    }
}