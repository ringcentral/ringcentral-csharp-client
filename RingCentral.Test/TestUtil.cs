using Xunit;
using Newtonsoft.Json;

namespace RingCentral.Test
{
    public static class TestUtil
    {
        public static void DeepEqual(object obj1, object obj2)
        {
            Assert.Equal(JsonConvert.SerializeObject(obj1), JsonConvert.SerializeObject(obj2));
        }
    }
}