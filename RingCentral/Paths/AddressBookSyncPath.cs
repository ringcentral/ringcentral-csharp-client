using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AddressBookSyncPath : PathSegment
    {
        internal AddressBookSyncPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "address-book-sync";
            }
        }
        // Synchronizes user contacts.
        public Task<AddressBookSync> List()
        {
            return RC.Get<AddressBookSync>(Endpoint(false), null);
        }
        // Synchronizes user contacts.
        public Task<AddressBookSync> List(object parameters)
        {
            return RC.Get<AddressBookSync>(Endpoint(false), parameters);
        }
        // Synchronizes user contacts.
        public Task<AddressBookSync> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Type of synchronization
            public string[] @syncType { get; set; }
            // Value of syncToken property of the last sync request response
            public string @syncToken { get; set; }
            // Number of records per page to be returned. The max number of records is 250, which is also the default. For 'FSync' if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For 'ISync' if the number of records exceeds the page size, the number of incoming changes to this number is limited
            public long? @perPage { get; set; }
            // Internal identifier of a page. It can be obtained from the 'nextPageId' parameter passed in response body
            public long? @pageId { get; set; }
        }
    }
}
