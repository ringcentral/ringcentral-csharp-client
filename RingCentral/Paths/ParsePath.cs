using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ParsePath : PathSegment
    {
        internal ParsePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "parse";
            }
        }
        // Parse Phone Number
        public Task<PostResponse> Post()
        {
            return RC.Post<PostResponse>(Endpoint(true), null);
        }
        // Parse Phone Number
        public Task<PostResponse> Post(object parameters)
        {
            return RC.Post<PostResponse>(Endpoint(true), parameters);
        }
        // Parse Phone Number
        public Task<PostResponse> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Internal identifier of a home country. The default value is ISO code (ISO 3166) of the user's home country or brand country, if the user is undefined
            public string @homeCountry { get; set; }
            // The default value is "False". If "True", the numbers that are closer to the home country are given higher priority
            public bool? @nationalAsPriority { get; set; }
        }
        public partial class PostResponse
        {
            // Canonical URI of a resource
            public string @uri { get; set; }
            // Information on a user home country
            public ParsePhoneNumber_CountryInfo[] @homeCountry { get; set; }
            // Parsed phone numbers data
            public ParsePhoneNumber_PhoneNumberInfo[] @phoneNumbers { get; set; }
            // One of the numbers to be parsed, passed as a string in response
            public string @originalString { get; set; }
            // Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details
            public string @areaCode { get; set; }
            // Domestic format of a phone number
            public string @formattedNational { get; set; }
            // International format of a phone number
            public string @formattedInternational { get; set; }
            // Dialing format of a phone number
            public string @dialable { get; set; }
            // E.164 (11-digits) format of a phone number
            public string @e164 { get; set; }
            // "True" if the number is in a special format (for example N11 code)
            public bool? @special { get; set; }
            // E.164 (11-digits) format of a phone number without the plus sign ('+')
            public string @normalized { get; set; }
            // Information on a country the phone number belongs to
            public ParsePhoneNumber_CountryInfo[] @country { get; set; }
        }
    }
}
