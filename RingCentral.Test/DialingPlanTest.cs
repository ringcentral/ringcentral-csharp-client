using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class DialingPlanTest : IDisposable
    {
        private RestClient rc;
        public DialingPlanTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void GetDialingPlans()
        {
            // "/restapi/v1.0/account/{accountId}/dialing-plan" is internal API, so
            //var account = rc.Restapi().Account();
            //var result = await account.DialingPlan().List();
            //Assert.NotNull(result);
            //Assert.NotEmpty(result.records);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
