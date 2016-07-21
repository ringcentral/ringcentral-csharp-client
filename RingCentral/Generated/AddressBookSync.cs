
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
        public class GetQueryParams
        {
            public string syncType { get; set; }
            public string syncToken { get; set; }
            public int? perPage { get; set; }
            public int? pageId { get; set; }
        }
        public class GetResponse
        {
            public Record[] records { get; set; }
            public SyncInfo syncInfo { get; set; }
            public int? nextPageId { get; set; }
            public string nextPageUri { get; set; }
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
            public class SyncInfo
            {
                public string syncType { get; set; }
                public string syncToken { get; set; }
                public string syncTime { get; set; }
            }
        }
    }
}
