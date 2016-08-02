using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Content
    {
        public Task<byte[]> Get()
        {
            return RC.GetBinary(Endpoint(true), null);
        }
    }
}
