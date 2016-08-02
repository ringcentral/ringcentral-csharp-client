using System.Threading.Tasks;

namespace RingCentral
{
    public partial class ProfileImage
    {
        public Task<byte[]> Get()
        {
            return RC.GetBinary(Endpoint(true), null);
        }

        public Task<byte[]> Post(byte[] requestBody)
        {
            return RC.PostBinary(Endpoint(false), requestBody, null);
        }

        public Task<byte[]> Put(byte[] requestBody)
        {
            return RC.PutBinary(Endpoint(false), requestBody, null);
        }
    }
}
