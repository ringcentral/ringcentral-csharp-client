using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ContactsPath : PathSegment
    {
        internal ContactsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "contacts";
            }
        }
        // Returns contact information on corporate users of federated accounts. Please note: 1. User, DigitalUser, VirtualUser and FaxUser types are returned as User type. 2.ApplicationExtension type is not returned. 3. Only extensions in Enabled, Disabled and NotActivated state are returned.
        public Task<DirectoryResource> List()
        {
            return RC.Get<DirectoryResource>(Endpoint(false), null);
        }
        // Returns contact information on corporate users of federated accounts. Please note: 1. User, DigitalUser, VirtualUser and FaxUser types are returned as User type. 2.ApplicationExtension type is not returned. 3. Only extensions in Enabled, Disabled and NotActivated state are returned.
        public Task<DirectoryResource> List(object parameters)
        {
            return RC.Get<DirectoryResource>(Endpoint(false), parameters);
        }
        // Returns contact information on corporate users of federated accounts. Please note: 1. User, DigitalUser, VirtualUser and FaxUser types are returned as User type. 2.ApplicationExtension type is not returned. 3. Only extensions in Enabled, Disabled and NotActivated state are returned.
        public Task<DirectoryResource> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // excludeFederatedContacts
            public string @excludeFederatedContacts { get; set; }
            // Type of an extension
            public string @type { get; set; }
            // page
            public string @page { get; set; }
            // perPage
            public string @perPage { get; set; }
            // Internal identifier of the business site to which extensions belongs
            public string @siteId { get; set; }
        }
        // Returns contact information on a particular corporate user of a federated account.
        public Task<ContactResource> Get()
        {
            return RC.Get<ContactResource>(Endpoint(true), null);
        }
    }
}
