using System.Net;
using System.Reflection;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class DictionaryTest
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
        public void TestGet()
        {
            var country = rc.Restapi().Dictionary().Country("46");
            var response = rc.Get(country.Endpoint()).Result;
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Contains("China", response.Content.ReadAsStringAsync().Result);

            var countryResponse = rc.Get<Country.GetResponse>(country.Endpoint()).Result;
            var countryResponse2 = rc.Restapi().Dictionary().Country("46").Get().Result;
            TestUtil.DeepEqual(countryResponse2, countryResponse);
        }

        [Fact]
        public void TestParameters()
        {
            var methodInfo = rc.Restapi().GetType().GetMethod("Dictionary");
            var parameters = methodInfo.GetParameters();
            Assert.Equal(0, parameters.Length);

            methodInfo = rc.Restapi().Dictionary().GetType().GetMethod("Timezone");
            parameters = methodInfo.GetParameters();
            Assert.Equal(1, parameters.Length);
        }
    }
}