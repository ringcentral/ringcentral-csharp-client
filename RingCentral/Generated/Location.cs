
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Location : Model
    {
        internal Location(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "location";
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
            public string orderBy { get; set; }
            public int? page { get; set; }
            public int? perPage { get; set; }
            public string stateId { get; set; }
            public bool? withNxx { get; set; }
        }
        public class ListResponse
        {
            public Record[] records { get; set; }
            public Navigation navigation { get; set; }
            public Paging paging { get; set; }
            public class Record
            {
                public string uri { get; set; }
                public string areaCode { get; set; }
                public string city { get; set; }
                public string npa { get; set; }
                public string nxx { get; set; }
                public string state { get; set; }
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
