using Xunit;
using System.IO;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class BinaryTest
    {
        private RestClient rc;
        private byte[] bytes;
        public BinaryTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
            bytes = File.ReadAllBytes("test.png");
        }

        [Fact]
        public void ProfileImage()
        {
            var extension = rc.Restapi().Account().Extension();

            var temp = extension.ProfileImage().Post(bytes, "test.png").Result;
            Assert.NotNull(temp);

            var bytes3 = extension.ProfileImage().Get().Result;
            Assert.NotNull(bytes3);
            Assert.Equal(bytes, bytes3);

            var bytes4 = extension.ProfileImage("90x90").Get().Result;
            Assert.NotNull(bytes4);

            temp = extension.ProfileImage().Put(bytes, "test.png").Result;
            Assert.NotNull(temp);

            var bytes5 = extension.ProfileImage().Get().Result;
            Assert.NotNull(bytes5);
            Assert.Equal(bytes, bytes5);

            var bytes6 = extension.ProfileImage("90x90").Get().Result;
            Assert.NotNull(bytes6);
        }
    }
}
