using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PhoneNumberPath : PathSegment
    {
        internal PhoneNumberPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "phone-number";
            }
        }
        // Returns the list of phone numbers that are used by a particular extension, and can be filtered by the phone number type. The returned list contains all numbers which are directly mapped to a given extension plus the features and also company-level numbers which may be used when performing different operations on behalf of this extension.
        public Task<GetExtensionPhoneNumbersResponse> List()
        {
            return RC.Get<GetExtensionPhoneNumbersResponse>(Endpoint(false), null);
        }
        // Returns the list of phone numbers that are used by a particular extension, and can be filtered by the phone number type. The returned list contains all numbers which are directly mapped to a given extension plus the features and also company-level numbers which may be used when performing different operations on behalf of this extension.
        public Task<GetExtensionPhoneNumbersResponse> List(object parameters)
        {
            return RC.Get<GetExtensionPhoneNumbersResponse>(Endpoint(false), parameters);
        }
        // Returns the list of phone numbers that are used by a particular extension, and can be filtered by the phone number type. The returned list contains all numbers which are directly mapped to a given extension plus the features and also company-level numbers which may be used when performing different operations on behalf of this extension.
        public Task<GetExtensionPhoneNumbersResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Usage type of a phone number
            public string[] @usageType { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
        // Returns the phone number(s) belonging to a certain account or extension by phoneNumberId(s). Batch request is supported.
        public Task<CompanyPhoneNumberInfo> Get()
        {
            return RC.Get<CompanyPhoneNumberInfo>(Endpoint(true), null);
        }
    }
}
