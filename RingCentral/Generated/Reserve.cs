
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Reserve : Model
    {
        internal Reserve(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "reserve";
            }
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public class PostRequest
        {
            public Record[] records { get; set; }
            public class Record
            {
                public string phoneNumber { get; set; }
                public string reservedTill { get; set; }
            }
        }
        public class PostResponse
        {
            public Record[] records { get; set; }
            public class Record
            {
                public string phoneNumber { get; set; }
                public string formattedNumber { get; set; }
                public string reservedTill { get; set; }
                public string reservationId { get; set; }
                public string status { get; set; }
                public string error { get; set; }
            }
        }
    }
}
