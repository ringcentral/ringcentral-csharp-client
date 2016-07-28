using System.Collections.Generic;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Fax
    {
        public Task<PostResponse> Post(object requestBody, IEnumerable<Attachment> attachments)
        {
            return null;
        }
        public Task<PostResponse> Post(PostRequest requestBody, IEnumerable<Attachment> attachments)
        {
            return Post(requestBody as object, attachments);
        }
    }

    public class Attachment
    {
        public string fileName { get; set; }
        public string contentType { get; set; }
        public byte[] bytes { get; set; }
    }
}
