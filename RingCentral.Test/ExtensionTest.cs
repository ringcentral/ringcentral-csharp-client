using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class ExtensionTest : IDisposable
    {
        private RestClient rc;
        public ExtensionTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void TestGet()
        {
            var extension = rc.Restapi().Account().Extension().Get().Result;
            Assert.NotNull(extension);
            Assert.True(extension.contact.firstName.Length > 0);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}