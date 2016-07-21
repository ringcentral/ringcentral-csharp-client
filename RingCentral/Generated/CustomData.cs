
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CustomData : Model
    {
        internal CustomData(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "custom-data";
            }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public class PutRequest
        {
            public string id { get; set; }
            public string value { get; set; }
        }
        public class PutResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string value { get; set; }
            public string lastModifiedTime { get; set; }
            public Attachment attachment { get; set; }
            public class Attachment
            {
                public string uri { get; set; }
                public string contentType { get; set; }
            }
        }
    }
}
