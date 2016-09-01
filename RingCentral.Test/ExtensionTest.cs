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
        public async void TestGet()
        {
            var extension = await rc.Restapi().Account().Extension().Get();
            Assert.NotNull(extension);
            Assert.True(extension.contact.firstName.Length > 0);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}