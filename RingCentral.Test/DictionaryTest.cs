using System;
using System.Net;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class DictionaryTest : IDisposable
    {
        private RestClient rc;
        public DictionaryTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void MockTest()
        {
            var rc = new RestClient("", "", "");
            var dictionary = rc.Restapi().Dictionary();
            Assert.NotNull(dictionary);
            var location = dictionary.Location();
            Assert.NotNull(location);
            var state = dictionary.State();
            Assert.NotNull(state);
        }

        [Fact]
        public async void TestGet()
        {
            var country = rc.Restapi().Dictionary().Country("46");
            var response = await rc.Get(country.Endpoint());
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Contains("China", await response.Content.ReadAsStringAsync());

            var countryResponse = await rc.Get<FullCountryInfo>(country.Endpoint());
            var countryResponse2 = await rc.Restapi().Dictionary().Country("46").Get();
            TestUtil.DeepEqual(countryResponse2, countryResponse);
        }

        [Fact]
        public void TestParameters()
        {
            var methodInfo = rc.Restapi().GetType().GetMethod("Dictionary");
            var parameters = methodInfo.GetParameters();
            Assert.Equal(0, parameters.Length);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}