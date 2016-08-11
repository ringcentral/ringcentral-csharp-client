
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AddressBookSync : Model
    {
        internal AddressBookSync(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "address-book-sync";
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
        public partial class GetQueryParams
        {
            // Type of synchronization. The default value is 'FSync'
            public string syncType { get; set; }
            // Value of syncToken property of the last sync request response
            public string syncToken { get; set; }
            // Number of records per page to be returned. The max number of records is 250, which is also the default. For FSync — if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For ISync — if the number of records exceeds the page size, the number of incoming changes to this number is limited
            public int? perPage { get; set; }
            // Internal identifier of a page. It can be obtained from the 'nextPageId' parameter passed in response body
            public int? pageId { get; set; }
        }
        public partial class GetResponse
        {
            // List of contacts with synchronization information
            public PersonalContactInfo[] records { get; set; }
            // Sync type, token and time
            public SyncInfo syncInfo { get; set; }
            // Internal identifier of the next page, if any
            public int? nextPageId { get; set; }
            // URL of the next page, if any
            public string nextPageUri { get; set; }
        }
    }
}
