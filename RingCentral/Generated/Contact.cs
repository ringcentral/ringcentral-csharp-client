
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Contact : Model
    {
        internal Contact(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "contact";
            }
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public class PostRequest
        {
            public int? id { get; set; }
            public string url { get; set; }
            public string availability { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string middleName { get; set; }
            public string nickName { get; set; }
            public string company { get; set; }
            public string jobTitle { get; set; }
            public string homePhone { get; set; }
            public string homePhone2 { get; set; }
            public string businessPhone { get; set; }
            public string businessPhone2 { get; set; }
            public string mobilePhone { get; set; }
            public string businessFax { get; set; }
            public string companyPhone { get; set; }
            public string assistantPhone { get; set; }
            public string carPhone { get; set; }
            public string otherPhone { get; set; }
            public string otherFax { get; set; }
            public string callbackPhone { get; set; }
            public string email { get; set; }
            public string email2 { get; set; }
            public string email3 { get; set; }
            public HomeAddress homeAddress { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public OtherAddress otherAddress { get; set; }
            public string birthday { get; set; }
            public string webPage { get; set; }
            public string notes { get; set; }
            public class HomeAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class OtherAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
        }
        public class PostResponse
        {
            public int? id { get; set; }
            public string url { get; set; }
            public string availability { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string middleName { get; set; }
            public string nickName { get; set; }
            public string company { get; set; }
            public string jobTitle { get; set; }
            public string homePhone { get; set; }
            public string homePhone2 { get; set; }
            public string businessPhone { get; set; }
            public string businessPhone2 { get; set; }
            public string mobilePhone { get; set; }
            public string businessFax { get; set; }
            public string companyPhone { get; set; }
            public string assistantPhone { get; set; }
            public string carPhone { get; set; }
            public string otherPhone { get; set; }
            public string otherFax { get; set; }
            public string callbackPhone { get; set; }
            public string email { get; set; }
            public string email2 { get; set; }
            public string email3 { get; set; }
            public HomeAddress homeAddress { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public OtherAddress otherAddress { get; set; }
            public string birthday { get; set; }
            public string webPage { get; set; }
            public string notes { get; set; }
            public class HomeAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class OtherAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
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
            public string phoneNumber { get; set; }
            public string startsWith { get; set; }
            public string sortBy { get; set; }
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
                public string url { get; set; }
                public string availability { get; set; }
                public string firstName { get; set; }
                public string lastName { get; set; }
                public string middleName { get; set; }
                public string nickName { get; set; }
                public string company { get; set; }
                public string jobTitle { get; set; }
                public string homePhone { get; set; }
                public string homePhone2 { get; set; }
                public string businessPhone { get; set; }
                public string businessPhone2 { get; set; }
                public string mobilePhone { get; set; }
                public string businessFax { get; set; }
                public string companyPhone { get; set; }
                public string assistantPhone { get; set; }
                public string carPhone { get; set; }
                public string otherPhone { get; set; }
                public string otherFax { get; set; }
                public string callbackPhone { get; set; }
                public string email { get; set; }
                public string email2 { get; set; }
                public string email3 { get; set; }
                public HomeAddress homeAddress { get; set; }
                public BusinessAddress businessAddress { get; set; }
                public OtherAddress otherAddress { get; set; }
                public string birthday { get; set; }
                public string webPage { get; set; }
                public string notes { get; set; }
                public class HomeAddress
                {
                    public string country { get; set; }
                    public string state { get; set; }
                    public string city { get; set; }
                    public string street { get; set; }
                    public string zip { get; set; }
                }
                public class BusinessAddress
                {
                    public string country { get; set; }
                    public string state { get; set; }
                    public string city { get; set; }
                    public string street { get; set; }
                    public string zip { get; set; }
                }
                public class OtherAddress
                {
                    public string country { get; set; }
                    public string state { get; set; }
                    public string city { get; set; }
                    public string street { get; set; }
                    public string zip { get; set; }
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
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public int? id { get; set; }
            public string url { get; set; }
            public string availability { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string middleName { get; set; }
            public string nickName { get; set; }
            public string company { get; set; }
            public string jobTitle { get; set; }
            public string homePhone { get; set; }
            public string homePhone2 { get; set; }
            public string businessPhone { get; set; }
            public string businessPhone2 { get; set; }
            public string mobilePhone { get; set; }
            public string businessFax { get; set; }
            public string companyPhone { get; set; }
            public string assistantPhone { get; set; }
            public string carPhone { get; set; }
            public string otherPhone { get; set; }
            public string otherFax { get; set; }
            public string callbackPhone { get; set; }
            public string email { get; set; }
            public string email2 { get; set; }
            public string email3 { get; set; }
            public HomeAddress homeAddress { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public OtherAddress otherAddress { get; set; }
            public string birthday { get; set; }
            public string webPage { get; set; }
            public string notes { get; set; }
            public class HomeAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class OtherAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public class PutRequest
        {
            public int? id { get; set; }
            public string url { get; set; }
            public string availability { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string middleName { get; set; }
            public string nickName { get; set; }
            public string company { get; set; }
            public string jobTitle { get; set; }
            public string homePhone { get; set; }
            public string homePhone2 { get; set; }
            public string businessPhone { get; set; }
            public string businessPhone2 { get; set; }
            public string mobilePhone { get; set; }
            public string businessFax { get; set; }
            public string companyPhone { get; set; }
            public string assistantPhone { get; set; }
            public string carPhone { get; set; }
            public string otherPhone { get; set; }
            public string otherFax { get; set; }
            public string callbackPhone { get; set; }
            public string email { get; set; }
            public string email2 { get; set; }
            public string email3 { get; set; }
            public HomeAddress homeAddress { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public OtherAddress otherAddress { get; set; }
            public string birthday { get; set; }
            public string webPage { get; set; }
            public string notes { get; set; }
            public class HomeAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class OtherAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
        }
        public class PutResponse
        {
            public int? id { get; set; }
            public string url { get; set; }
            public string availability { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string middleName { get; set; }
            public string nickName { get; set; }
            public string company { get; set; }
            public string jobTitle { get; set; }
            public string homePhone { get; set; }
            public string homePhone2 { get; set; }
            public string businessPhone { get; set; }
            public string businessPhone2 { get; set; }
            public string mobilePhone { get; set; }
            public string businessFax { get; set; }
            public string companyPhone { get; set; }
            public string assistantPhone { get; set; }
            public string carPhone { get; set; }
            public string otherPhone { get; set; }
            public string otherFax { get; set; }
            public string callbackPhone { get; set; }
            public string email { get; set; }
            public string email2 { get; set; }
            public string email3 { get; set; }
            public HomeAddress homeAddress { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public OtherAddress otherAddress { get; set; }
            public string birthday { get; set; }
            public string webPage { get; set; }
            public string notes { get; set; }
            public class HomeAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
            public class OtherAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
        }
    }
}
