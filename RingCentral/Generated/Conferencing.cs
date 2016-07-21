
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Conferencing : Model
    {
        internal Conferencing(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "conferencing";
            }
        }
        public Task<GetResponse> Get(object queryParams)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return Get(queryParams as object);
        }
        public class GetQueryParams
        {
            public string countryId { get; set; }
        }
        public class GetResponse
        {
            public string uri { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public string hostCode { get; set; }
            public string mode { get; set; }
            public string participantCode { get; set; }
            public string phoneNumber { get; set; }
            public string tapToJoinUri { get; set; }
            public PhoneNumber[] phoneNumbers { get; set; }
            public class PhoneNumber
            {
                public Country country { get; set; }
                public bool? @default { get; set; }
                public bool? hasGreeting { get; set; }
                public string location { get; set; }
                public string phoneNumber { get; set; }
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
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public class PutRequest
        {
            public PhoneNumber[] phoneNumbers { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public class PhoneNumber
            {
                public string phoneNumber { get; set; }
                public bool? @default { get; set; }
            }
        }
        public class PutResponse
        {
            public string uri { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public string hostCode { get; set; }
            public string mode { get; set; }
            public string participantCode { get; set; }
            public string phoneNumber { get; set; }
            public string tapToJoinUri { get; set; }
            public PhoneNumber[] phoneNumbers { get; set; }
            public class PhoneNumber
            {
                public Country country { get; set; }
                public bool? @default { get; set; }
                public bool? hasGreeting { get; set; }
                public string location { get; set; }
                public string phoneNumber { get; set; }
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
}
