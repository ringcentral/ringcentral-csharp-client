
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Language : Model
    {
        internal Language(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "language";
            }
        }
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // Language data
            public LanguageInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of a language
            public string id { get; set; }
            // Canonical URI of a language
            public string uri { get; set; }
            // Indicates whether a language is available as greeting language
            public bool? greeting { get; set; }
            // Indicates whether a language is available as formatting locale
            public bool? formattingLocale { get; set; }
            // Localization code of a language
            public string localeCode { get; set; }
            // Official name of a language
            public string name { get; set; }
            // Indicates whether a language is available as UI language
            public bool? ui { get; set; }
        }
    }
}
