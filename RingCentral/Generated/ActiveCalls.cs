
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ActiveCalls : Model
    {
        internal ActiveCalls(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "active-calls";
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
            public string direction { get; set; }
            public string type { get; set; }
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
                public string id { get; set; }
                public string uri { get; set; }
                public string sessionId { get; set; }
                public From from { get; set; }
                public To to { get; set; }
                public string type { get; set; }
                public string direction { get; set; }
                public string action { get; set; }
                public string result { get; set; }
                public string startTime { get; set; }
                public int? duration { get; set; }
                public Recording recording { get; set; }
                public string lastModifiedTime { get; set; }
                public string transport { get; set; }
                public Leg[] legs { get; set; }
                public class From
                {
                    public string phoneNumber { get; set; }
                    public string extensionNumber { get; set; }
                    public string location { get; set; }
                    public string name { get; set; }
                }
                public class To
                {
                    public string phoneNumber { get; set; }
                    public string extensionNumber { get; set; }
                    public string location { get; set; }
                    public string name { get; set; }
                }
                public class Recording
                {
                    public int? id { get; set; }
                    public string uri { get; set; }
                    public string type { get; set; }
                    public string contentUri { get; set; }
                }
                public class Leg
                {
                    public string action { get; set; }
                    public string direction { get; set; }
                    public int? duration { get; set; }
                    public Extension extension { get; set; }
                    public string legType { get; set; }
                    public string startTime { get; set; }
                    public string type { get; set; }
                    public string result { get; set; }
                    public From from { get; set; }
                    public To to { get; set; }
                    public string transport { get; set; }
                    public Recording recording { get; set; }
                    public class Extension
                    {
                        public int? id { get; set; }
                        public string uri { get; set; }
                    }
                    public class From
                    {
                        public string phoneNumber { get; set; }
                        public string extensionNumber { get; set; }
                        public string location { get; set; }
                        public string name { get; set; }
                    }
                    public class To
                    {
                        public string phoneNumber { get; set; }
                        public string extensionNumber { get; set; }
                        public string location { get; set; }
                        public string name { get; set; }
                    }
                    public class Recording
                    {
                        public int? id { get; set; }
                        public string uri { get; set; }
                        public string type { get; set; }
                        public string contentUri { get; set; }
                    }
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
