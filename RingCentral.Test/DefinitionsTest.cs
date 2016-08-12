using Xunit;

namespace RingCentral.Test
{
    public class DefinitionsTest
    {
        [Fact]
        public void AllTheDefinitions()
        {
            var rc = new RestClient("", "");
            var restApi = rc.Restapi();
            var account = restApi.Account();
            var dict = restApi.Dictionary();

            Assert.NotNull(account);
            Assert.NotNull(dict);
        }
    }
}
