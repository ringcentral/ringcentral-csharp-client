
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Lookup : Model
    {
        internal Lookup(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "lookup";
            }
        }
        public Task<PostResponse> Post(object queryParams)
        {
            return RC.Post<PostResponse>(Endpoint(false), null, queryParams);
        }
        public Task<PostResponse> Post(PostQueryParams queryParams)
        {
            return Post(queryParams as object);
        }
        public class PostQueryParams
        {
            public int? areaCode { get; set; }
            public string countryCode { get; set; }
            public string countryId { get; set; }
            public string exclude { get; set; }
            public bool? extendedSearch { get; set; }
            public string line { get; set; }
            public string numberPattern { get; set; }
            public string nxx { get; set; }
            public string npa { get; set; }
            public string paymentType { get; set; }
            public int? perPage { get; set; }
            public bool? smsEnabled { get; set; }
        }
        public class PostResponse
        {
            public string uri { get; set; }
            public Record[] records { get; set; }
            public class Record
            {
                public string phoneNumber { get; set; }
                public string formattedNumber { get; set; }
                public string vanityPattern { get; set; }
                public int? rank { get; set; }
            }
        }
    }
}
