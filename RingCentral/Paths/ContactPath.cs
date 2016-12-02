using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ContactPath : PathSegment
    {
        internal ContactPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "contact";
            }
        }
        // Create New Contact
        public Task<PersonalContactInfo> Post()
        {
            return RC.Post<PersonalContactInfo>(Endpoint(true), null);
        }
        // Create New Contact
        public Task<PersonalContactInfo> Post(object parameters)
        {
            return RC.Post<PersonalContactInfo>(Endpoint(true), parameters);
        }
        // Create New Contact
        public Task<PersonalContactInfo> Post(PersonalContactInfo parameters)
        {
            return Post(parameters as object);
        }
        // Get Contact List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Contact List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Contact List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Phone number in E.164 (11-digits) format with or without plus '+'. Multiple values are supported
            public string @phoneNumber { get; set; }
            // If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive
            public string @startsWith { get; set; }
            // Sorts results by the specified property. The default is 'First Name'
            public string @sortBy { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of personal contacts from the extension address book
            public PersonalContactInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Delete Contact by ID
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Get Contact by ID
        public Task<PersonalContactInfo> Get()
        {
            return RC.Get<PersonalContactInfo>(Endpoint(true), null);
        }
        // Update Contact by ID
        public Task<PersonalContactInfo> Put()
        {
            return RC.Put<PersonalContactInfo>(Endpoint(true), null);
        }
        // Update Contact by ID
        public Task<PersonalContactInfo> Put(object parameters)
        {
            return RC.Put<PersonalContactInfo>(Endpoint(true), parameters);
        }
        // Update Contact by ID
        public Task<PersonalContactInfo> Put(PersonalContactInfo parameters)
        {
            return Put(parameters as object);
        }
    }
}
