
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Contact : Model
    {
        internal Contact(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "contact";
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
        public partial class PostRequest
        {
            // Standard resource properties ID
            public int? id { get; set; }
            // Canonical URI
            public string url { get; set; }
            // This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
            public string availability { get; set; }
            // First name of a personal contact
            public string firstName { get; set; }
            // Last name of a personal contact
            public string lastName { get; set; }
            // Middle name of a personal contact
            public string middleName { get; set; }
            // Nick name of a personal contact
            public string nickName { get; set; }
            // Company name of a personal contact
            public string company { get; set; }
            // Job title of a personal contact
            public string jobTitle { get; set; }
            // Home phone of a personal contact
            public string homePhone { get; set; }
            // The 2-d home phone of a personal contact
            public string homePhone2 { get; set; }
            // Business phone of a personal contact
            public string businessPhone { get; set; }
            // The 2-d business phone of a personal contact
            public string businessPhone2 { get; set; }
            // Mobile phone of a personal contact
            public string mobilePhone { get; set; }
            // Business fax of a personal contact
            public string businessFax { get; set; }
            // Company phone of a personal contact
            public string companyPhone { get; set; }
            // Assistant phone of a personal contact
            public string assistantPhone { get; set; }
            // Car phone of a personal contact
            public string carPhone { get; set; }
            // Other phone of a personal contact
            public string otherPhone { get; set; }
            // Other fax of a personal contact
            public string otherFax { get; set; }
            // Callback phone of a personal contact
            public string callbackPhone { get; set; }
            // Email of a personal contact
            public string email { get; set; }
            // The 2-d email of a personal contact
            public string email2 { get; set; }
            // The 3-d email of a personal contact
            public string email3 { get; set; }
            // Home address of a personal contact
            public ContactAddressInfo homeAddress { get; set; }
            // Business address of a personal contact
            public ContactAddressInfo businessAddress { get; set; }
            // Other address of a personal contact
            public ContactAddressInfo otherAddress { get; set; }
            // Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string birthday { get; set; }
            // Web page of a personal contact
            public string webPage { get; set; }
            // Notes of a personal contact
            public string notes { get; set; }
        }
        public partial class PostResponse
        {
            // Standard resource properties ID
            public int? id { get; set; }
            // Canonical URI
            public string url { get; set; }
            // This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
            public string availability { get; set; }
            // First name of a personal contact
            public string firstName { get; set; }
            // Last name of a personal contact
            public string lastName { get; set; }
            // Middle name of a personal contact
            public string middleName { get; set; }
            // Nick name of a personal contact
            public string nickName { get; set; }
            // Company name of a personal contact
            public string company { get; set; }
            // Job title of a personal contact
            public string jobTitle { get; set; }
            // Home phone of a personal contact
            public string homePhone { get; set; }
            // The 2-d home phone of a personal contact
            public string homePhone2 { get; set; }
            // Business phone of a personal contact
            public string businessPhone { get; set; }
            // The 2-d business phone of a personal contact
            public string businessPhone2 { get; set; }
            // Mobile phone of a personal contact
            public string mobilePhone { get; set; }
            // Business fax of a personal contact
            public string businessFax { get; set; }
            // Company phone of a personal contact
            public string companyPhone { get; set; }
            // Assistant phone of a personal contact
            public string assistantPhone { get; set; }
            // Car phone of a personal contact
            public string carPhone { get; set; }
            // Other phone of a personal contact
            public string otherPhone { get; set; }
            // Other fax of a personal contact
            public string otherFax { get; set; }
            // Callback phone of a personal contact
            public string callbackPhone { get; set; }
            // Email of a personal contact
            public string email { get; set; }
            // The 2-d email of a personal contact
            public string email2 { get; set; }
            // The 3-d email of a personal contact
            public string email3 { get; set; }
            // Home address of a personal contact
            public ContactAddressInfo homeAddress { get; set; }
            // Business address of a personal contact
            public ContactAddressInfo businessAddress { get; set; }
            // Other address of a personal contact
            public ContactAddressInfo otherAddress { get; set; }
            // Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string birthday { get; set; }
            // Web page of a personal contact
            public string webPage { get; set; }
            // Notes of a personal contact
            public string notes { get; set; }
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public partial class ListQueryParams
        {
            // Phone number in E.164 (11-digits) format with or without plus '+'. Multiple values are supported
            public string phoneNumber { get; set; }
            // If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive
            public string startsWith { get; set; }
            // Sorts results by the specified property. The default is 'First Name'
            public string sortBy { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public int? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public int? perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of personal contacts from the extension address book
            public PersonalContactInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Standard resource properties ID
            public int? id { get; set; }
            // Canonical URI
            public string url { get; set; }
            // This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
            public string availability { get; set; }
            // First name of a personal contact
            public string firstName { get; set; }
            // Last name of a personal contact
            public string lastName { get; set; }
            // Middle name of a personal contact
            public string middleName { get; set; }
            // Nick name of a personal contact
            public string nickName { get; set; }
            // Company name of a personal contact
            public string company { get; set; }
            // Job title of a personal contact
            public string jobTitle { get; set; }
            // Home phone of a personal contact
            public string homePhone { get; set; }
            // The 2-d home phone of a personal contact
            public string homePhone2 { get; set; }
            // Business phone of a personal contact
            public string businessPhone { get; set; }
            // The 2-d business phone of a personal contact
            public string businessPhone2 { get; set; }
            // Mobile phone of a personal contact
            public string mobilePhone { get; set; }
            // Business fax of a personal contact
            public string businessFax { get; set; }
            // Company phone of a personal contact
            public string companyPhone { get; set; }
            // Assistant phone of a personal contact
            public string assistantPhone { get; set; }
            // Car phone of a personal contact
            public string carPhone { get; set; }
            // Other phone of a personal contact
            public string otherPhone { get; set; }
            // Other fax of a personal contact
            public string otherFax { get; set; }
            // Callback phone of a personal contact
            public string callbackPhone { get; set; }
            // Email of a personal contact
            public string email { get; set; }
            // The 2-d email of a personal contact
            public string email2 { get; set; }
            // The 3-d email of a personal contact
            public string email3 { get; set; }
            // Home address of a personal contact
            public ContactAddressInfo homeAddress { get; set; }
            // Business address of a personal contact
            public ContactAddressInfo businessAddress { get; set; }
            // Other address of a personal contact
            public ContactAddressInfo otherAddress { get; set; }
            // Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string birthday { get; set; }
            // Web page of a personal contact
            public string webPage { get; set; }
            // Notes of a personal contact
            public string notes { get; set; }
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
            // Standard resource properties ID
            public int? id { get; set; }
            // Canonical URI
            public string url { get; set; }
            // This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
            public string availability { get; set; }
            // First name of a personal contact
            public string firstName { get; set; }
            // Last name of a personal contact
            public string lastName { get; set; }
            // Middle name of a personal contact
            public string middleName { get; set; }
            // Nick name of a personal contact
            public string nickName { get; set; }
            // Company name of a personal contact
            public string company { get; set; }
            // Job title of a personal contact
            public string jobTitle { get; set; }
            // Home phone of a personal contact
            public string homePhone { get; set; }
            // The 2-d home phone of a personal contact
            public string homePhone2 { get; set; }
            // Business phone of a personal contact
            public string businessPhone { get; set; }
            // The 2-d business phone of a personal contact
            public string businessPhone2 { get; set; }
            // Mobile phone of a personal contact
            public string mobilePhone { get; set; }
            // Business fax of a personal contact
            public string businessFax { get; set; }
            // Company phone of a personal contact
            public string companyPhone { get; set; }
            // Assistant phone of a personal contact
            public string assistantPhone { get; set; }
            // Car phone of a personal contact
            public string carPhone { get; set; }
            // Other phone of a personal contact
            public string otherPhone { get; set; }
            // Other fax of a personal contact
            public string otherFax { get; set; }
            // Callback phone of a personal contact
            public string callbackPhone { get; set; }
            // Email of a personal contact
            public string email { get; set; }
            // The 2-d email of a personal contact
            public string email2 { get; set; }
            // The 3-d email of a personal contact
            public string email3 { get; set; }
            // Home address of a personal contact
            public ContactAddressInfo homeAddress { get; set; }
            // Business address of a personal contact
            public ContactAddressInfo businessAddress { get; set; }
            // Other address of a personal contact
            public ContactAddressInfo otherAddress { get; set; }
            // Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string birthday { get; set; }
            // Web page of a personal contact
            public string webPage { get; set; }
            // Notes of a personal contact
            public string notes { get; set; }
        }
        public partial class PutResponse
        {
            // Standard resource properties ID
            public int? id { get; set; }
            // Canonical URI
            public string url { get; set; }
            // This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
            public string availability { get; set; }
            // First name of a personal contact
            public string firstName { get; set; }
            // Last name of a personal contact
            public string lastName { get; set; }
            // Middle name of a personal contact
            public string middleName { get; set; }
            // Nick name of a personal contact
            public string nickName { get; set; }
            // Company name of a personal contact
            public string company { get; set; }
            // Job title of a personal contact
            public string jobTitle { get; set; }
            // Home phone of a personal contact
            public string homePhone { get; set; }
            // The 2-d home phone of a personal contact
            public string homePhone2 { get; set; }
            // Business phone of a personal contact
            public string businessPhone { get; set; }
            // The 2-d business phone of a personal contact
            public string businessPhone2 { get; set; }
            // Mobile phone of a personal contact
            public string mobilePhone { get; set; }
            // Business fax of a personal contact
            public string businessFax { get; set; }
            // Company phone of a personal contact
            public string companyPhone { get; set; }
            // Assistant phone of a personal contact
            public string assistantPhone { get; set; }
            // Car phone of a personal contact
            public string carPhone { get; set; }
            // Other phone of a personal contact
            public string otherPhone { get; set; }
            // Other fax of a personal contact
            public string otherFax { get; set; }
            // Callback phone of a personal contact
            public string callbackPhone { get; set; }
            // Email of a personal contact
            public string email { get; set; }
            // The 2-d email of a personal contact
            public string email2 { get; set; }
            // The 3-d email of a personal contact
            public string email3 { get; set; }
            // Home address of a personal contact
            public ContactAddressInfo homeAddress { get; set; }
            // Business address of a personal contact
            public ContactAddressInfo businessAddress { get; set; }
            // Other address of a personal contact
            public ContactAddressInfo otherAddress { get; set; }
            // Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string birthday { get; set; }
            // Web page of a personal contact
            public string webPage { get; set; }
            // Notes of a personal contact
            public string notes { get; set; }
        }
    }
}
