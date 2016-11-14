using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AddressBookSyncPath : Model
    {
        internal AddressBookSyncPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "address-book-sync";
            }
        }
        // Contacts Synchronization
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        // Contacts Synchronization
        public Task<GetResponse> Get(object parameters)
        {
            return RC.Get<GetResponse>(Endpoint(true), parameters);
        }
        // Contacts Synchronization
        public Task<GetResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Type of synchronization. The default value is 'FSync'
            public string @syncType { get; set; }
            // Value of syncToken property of the last sync request response
            public string @syncToken { get; set; }
            // Number of records per page to be returned. The max number of records is 250, which is also the default. For FSync — if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For ISync — if the number of records exceeds the page size, the number of incoming changes to this number is limited
            public long? @perPage { get; set; }
            // Internal identifier of a page. It can be obtained from the 'nextPageId' parameter passed in response body
            public long? @pageId { get; set; }
        }
        public partial class GetResponse
        {
            // List of contacts with synchronization information
            public PersonalContactInfo[] @records { get; set; }
            // Sync type, token and time
            public SyncInfo @syncInfo { get; set; }
            // Internal identifier of the next page, if any
            public long? @nextPageId { get; set; }
            // URL of the next page, if any
            public string @nextPageUri { get; set; }
        }
    }
}
