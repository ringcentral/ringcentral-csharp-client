
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
        public partial class PutRequest
        {
            // Custom data access key. Optional. If specified, must match the custom key in the URL
            public string id { get; set; }
            // Description of custom data. Mandatory for create, if there is no attachment specified. Maximum length is limited to 256 symbols
            public string value { get; set; }
        }
        public partial class PutResponse
        {
            // Custom data access key
            public string id { get; set; }
            // Link to the custom data
            public string uri { get; set; }
            // Description of custom data
            public string value { get; set; }
            // Time of the last change in custom data
            public string lastModifiedTime { get; set; }
            // Attachment data: link and type
            public AttachmentInfo attachment { get; set; }
        }
    }
}
