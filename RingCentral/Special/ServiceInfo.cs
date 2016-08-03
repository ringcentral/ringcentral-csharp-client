using System.Threading.Tasks;

namespace RingCentral
{
    public partial class ServiceInfo
    {
        public Task<T> Get<T>()
        {
            return RC.Get<T>(Endpoint(true), null);
        }
    }
}
