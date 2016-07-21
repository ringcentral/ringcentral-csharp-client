
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Grant : Model
    {
        internal Grant(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "grant";
            }
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public class ListQueryParams
        {
            public int? page { get; set; }
            public int? perPage { get; set; }
        }
        public class ListResponse
        {
            public Record[] records { get; set; }
            public Navigation navigation { get; set; }
            public Paging paging { get; set; }
            public class Record
            {
                public string uri { get; set; }
                public Extension extension { get; set; }
                public bool? callPickup { get; set; }
                public bool? callMonitoring { get; set; }
                public class Extension
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string extensionNumber { get; set; }
                    public string type { get; set; }
                }
            }
            public class Navigation
            {
                public FirstPage firstPage { get; set; }
                public NextPage nextPage { get; set; }
                public PreviousPage previousPage { get; set; }
                public LastPage lastPage { get; set; }
                public class FirstPage
                {
                    public string uri { get; set; }
                }
                public class NextPage
                {
                    public string uri { get; set; }
                }
                public class PreviousPage
                {
                    public string uri { get; set; }
                }
                public class LastPage
                {
                    public string uri { get; set; }
                }
            }
            public class Paging
            {
                public int? page { get; set; }
                public int? perPage { get; set; }
                public int? pageStart { get; set; }
                public int? pageEnd { get; set; }
                public int? totalPages { get; set; }
                public int? totalElements { get; set; }
            }
        }
    }
}
