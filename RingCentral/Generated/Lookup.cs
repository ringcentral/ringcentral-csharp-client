
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
        public partial class PostQueryParams
        {
            // Area code of the location
            public int? areaCode { get; set; }
            // Two-letter country code, complying with the ISO standard
            public string countryCode { get; set; }
            // Internal identifier of a country; '1'- the US; '39' - Canada; '224' - the UK. The default value is '1'
            public string countryId { get; set; }
            // A string of digits (one and more) that should not appear among the last four digits (line part) of the phone numbers that will be returned. It is possible to specify several exclude parameters. If specified, it is taken into account in all returned phone numbers both in the phone numbers satisfying to parameters of lookup and in alternative phone numbers (in case when extendedSearch is specified)
            public string exclude { get; set; }
            // If the value is 'False', then the returned numbers exactly correspond to the specified NXX, NPA and LINE or countryCode, areaCode and numberPattern parameters. If the value is 'True', then the resulting numbers are ranked and returned with the rank attribute values (1-10). The default value is 'False'
            public bool? extendedSearch { get; set; }
            // LINE pattern for vanity or wildcard search. Digits, Latin characters and asterisks are allowed (usually 4 characters)
            public string line { get; set; }
            // Phone number pattern (for wildcard or vanity search). For NANP countries (US, Canada) is concatenation of nxx (the first three digits) and line. If the first three characters are specified as not digits (e.g. 5** or CAT) then parameter extendedSearch will be ignored.
            public string numberPattern { get; set; }
            // NXX pattern for vanity or wildcard search. Digits, Latin characters and asterisks are allowed (usually 3 characters)
            public string nxx { get; set; }
            // Area code (mandatory). For example, 800, 844, 855, 866, 877, 888 for North America; and 647 for Canada
            public string npa { get; set; }
            // Payment type. Default is 'Local' (it should correlate with the npa provided)
            public string paymentType { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '10' by default
            public int? perPage { get; set; }
            // Specifies if SMS activation is available for the number. If specified, it is taken into account in all returned phone numbers both in the phone numbers satisfying to parameters of lookup and in alternative phone numbers (in case when extendedSearch is specified). If not specified, the value is null.
            public bool? smsEnabled { get; set; }
        }
        public partial class PostResponse
        {
            // Canonical URI of the phone numbers resource
            public string uri { get; set; }
            // List of phone numbers filtered by the specified criteria
            public LookUpPhoneNumber_PhoneNumberInfo[] records { get; set; }
        }
    }
}
