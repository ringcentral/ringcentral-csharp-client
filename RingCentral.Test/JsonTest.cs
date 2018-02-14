using System.Text;
using Xunit;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

namespace RingCentral.Test
{
    public class JsonTest
    {
        [Fact]
        public void ParseJson()
        {
            var jsonStr = "{\"uuid\":\"3607412642158620871\",\"event\":\"/restapi/v1.0/account/130829004/extension/130829004/message-store\",\"timestamp\":\"2018-02-14T01:41:17.055Z\",\"subscriptionId\":\"768f0cef-9c46-47f8-bcd9-03968e6eb0b9\",\"ownerId\":\"130829004\",\"body\":{\"extensionId\":130829004,\"lastUpdated\":\"2018-02-14T01:41:07.708+0000\",\"changes\":[{\"type\":\"Fax\",\"newCount\":0,\"updatedCount\":2},{\"type\":\"SMS\",\"newCount\":1,\"updatedCount\":0}]}}";
            dynamic jo = JObject.Parse(jsonStr);
            var bodyString = JsonConvert.SerializeObject(jo.body);
            var messageEvent = JsonConvert.DeserializeObject<MessageEvent>(bodyString);
        }
    }
}
