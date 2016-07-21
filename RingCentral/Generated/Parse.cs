
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Parse : Model
    {
        internal Parse(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "parse";
            }
        }
        public Task<PostResponse> Post(object requestBody, object queryParams)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, queryParams);
        }
        public Task<PostResponse> Post(PostRequest requestBody, object queryParams)
        {
            return Post(requestBody as object, queryParams);
        }
        public Task<PostResponse> Post(object requestBody, PostQueryParams queryParams = null)
        {
            return Post(requestBody, queryParams as object);
        }
        public Task<PostResponse> Post(PostRequest requestBody, PostQueryParams queryParams = null)
        {
            return Post(requestBody as object, queryParams as object);
        }
        public class PostQueryParams
        {
            public string homeCountry { get; set; }
            public bool? nationalAsPriority { get; set; }
        }
        public class PostRequest
        {
            public string[] originalStrings { get; set; }
        }
        public class PostResponse
        {
            public string uri { get; set; }
            public HomeCountry[] homeCountry { get; set; }
            public PhoneNumber[] phoneNumbers { get; set; }
            public string originalString { get; set; }
            public string areaCode { get; set; }
            public string formattedNational { get; set; }
            public string formattedInternational { get; set; }
            public string dialable { get; set; }
            public string e164 { get; set; }
            public bool? special { get; set; }
            public string normalized { get; set; }
            public Country[] country { get; set; }
            public class HomeCountry
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string callingCode { get; set; }
                public bool? emergencyCalling { get; set; }
                public string isoCode { get; set; }
                public string name { get; set; }
            }
            public class PhoneNumber
            {
                public string areaCode { get; set; }
                public Country[] country { get; set; }
                public string dialable { get; set; }
                public string e164 { get; set; }
                public string formattedInternational { get; set; }
                public string formattedNational { get; set; }
                public string originalString { get; set; }
                public bool? special { get; set; }
                public string normalized { get; set; }
                public class Country
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string callingCode { get; set; }
                    public bool? emergencyCalling { get; set; }
                    public string isoCode { get; set; }
                    public string name { get; set; }
                }
            }
            public class Country
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string callingCode { get; set; }
                public bool? emergencyCalling { get; set; }
                public string isoCode { get; set; }
                public string name { get; set; }
            }
        }
    }
}
