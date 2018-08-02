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
        // Returns user personal contacts.
        public Task<ContactList> List()
        {
            return RC.Get<ContactList>(Endpoint(false), null);
        }
        // Returns user personal contacts.
        public Task<ContactList> List(object parameters)
        {
            return RC.Get<ContactList>(Endpoint(false), parameters);
        }
        // Returns user personal contacts.
        public Task<ContactList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive
            public string @startsWith { get; set; }
            // Sorts results by the specified property
            public string[] @sortBy { get; set; }
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            //
            public string[] @phoneNumber { get; set; }
        }
        // Creates personal user contact.
        public Task<PersonalContactResource> Post()
        {
            return RC.Post<PersonalContactResource>(Endpoint(true), null);
        }
        // Creates personal user contact.
        public Task<PersonalContactResource> Post(object parameters)
        {
            return RC.Post<PersonalContactResource>(Endpoint(true), parameters);
        }
        // Creates personal user contact.
        public Task<PersonalContactResource> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension
            public string @dialingPlan { get; set; }
        }
        // Returns contact(s) by ID(s). Batch request is supported.
        public Task<PersonalContactResource> Get()
        {
            return RC.Get<PersonalContactResource>(Endpoint(true), null);
        }
        // Updates personal contact information by contact ID(s). Batch request is supported
        public Task<PersonalContactResource> Put()
        {
            return RC.Put<PersonalContactResource>(Endpoint(true), null);
        }
        // Updates personal contact information by contact ID(s). Batch request is supported
        public Task<PersonalContactResource> Put(object parameters)
        {
            return RC.Put<PersonalContactResource>(Endpoint(true), parameters);
        }
        // Updates personal contact information by contact ID(s). Batch request is supported
        public Task<PersonalContactResource> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension
            public string @dialingPlan { get; set; }
        }
        // Deletes contact(s) by ID(s). Batch request is supported.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
