using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LanguagePath : PathSegment
    {
        internal LanguagePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "language";
            }
        }
        // Get Supported Language List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // Language data
            public LanguageInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get Language by ID
        public Task<LanguageInfo> Get()
        {
            return RC.Get<LanguageInfo>(Endpoint(true), null);
        }
    }
}
