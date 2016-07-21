
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PhoneNumber : Model
    {
        internal PhoneNumber(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "phone-number";
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
            public string usageType { get; set; }
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
                public int? id { get; set; }
                public Country country { get; set; }
                public Extension extension { get; set; }
                public string[] features { get; set; }
                public string location { get; set; }
                public string paymentType { get; set; }
                public string phoneNumber { get; set; }
                public string status { get; set; }
                public string type { get; set; }
                public string usageType { get; set; }
                public class Country
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string name { get; set; }
                }
                public class Extension
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string extensionNumber { get; set; }
                    public string partnerId { get; set; }
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
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public int? id { get; set; }
            public Country country { get; set; }
            public Extension extension { get; set; }
            public string[] features { get; set; }
            public string location { get; set; }
            public string paymentType { get; set; }
            public string phoneNumber { get; set; }
            public string status { get; set; }
            public string type { get; set; }
            public string usageType { get; set; }
            public class Country
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string name { get; set; }
            }
            public class Extension
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string extensionNumber { get; set; }
                public string partnerId { get; set; }
            }
        }
    }
}
