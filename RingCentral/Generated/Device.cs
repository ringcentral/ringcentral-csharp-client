
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Device : Model
    {
        internal Device(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "device";
            }
        }
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
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
                public string sku { get; set; }
                public string type { get; set; }
                public string name { get; set; }
                public string serial { get; set; }
                public string computerName { get; set; }
                public Model model { get; set; }
                public Extension extension { get; set; }
                public EmergencyServiceAddress emergencyServiceAddress { get; set; }
                public PhoneLines phoneLines { get; set; }
                public Shipping shipping { get; set; }
                public int? boxBillingId { get; set; }
                public class Model
                {
                    public string id { get; set; }
                    public string name { get; set; }
                    public Addon[] addons { get; set; }
                    public class Addon
                    {
                        public string id { get; set; }
                        public int? count { get; set; }
                    }
                }
                public class Extension
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string extensionNumber { get; set; }
                    public string partnerId { get; set; }
                }
                public class EmergencyServiceAddress
                {
                    public string customerName { get; set; }
                    public string street { get; set; }
                    public string street2 { get; set; }
                    public string city { get; set; }
                    public string state { get; set; }
                    public string zip { get; set; }
                    public string country { get; set; }
                }
                public class PhoneLines
                {
                    public string lineType { get; set; }
                    public PhoneInfo phoneInfo { get; set; }
                    public class PhoneInfo
                    {
                        public int? id { get; set; }
                        public Country country { get; set; }
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
                    }
                }
                public class Shipping
                {
                    public string status { get; set; }
                    public string carrier { get; set; }
                    public string trackingNumber { get; set; }
                    public Method[] method { get; set; }
                    public Address[] address { get; set; }
                    public class Method
                    {
                        public string id { get; set; }
                        public string name { get; set; }
                    }
                    public class Address
                    {
                        public string customerName { get; set; }
                        public string street { get; set; }
                        public string street2 { get; set; }
                        public string city { get; set; }
                        public string state { get; set; }
                        public string zip { get; set; }
                        public string country { get; set; }
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
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string sku { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string serial { get; set; }
            public string computerName { get; set; }
            public Model model { get; set; }
            public Extension extension { get; set; }
            public EmergencyServiceAddress emergencyServiceAddress { get; set; }
            public PhoneLines phoneLines { get; set; }
            public Shipping shipping { get; set; }
            public int? boxBillingId { get; set; }
            public class Model
            {
                public string id { get; set; }
                public string name { get; set; }
                public Addon[] addons { get; set; }
                public class Addon
                {
                    public string id { get; set; }
                    public int? count { get; set; }
                }
            }
            public class Extension
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string extensionNumber { get; set; }
                public string partnerId { get; set; }
            }
            public class EmergencyServiceAddress
            {
                public string customerName { get; set; }
                public string street { get; set; }
                public string street2 { get; set; }
                public string city { get; set; }
                public string state { get; set; }
                public string zip { get; set; }
                public string country { get; set; }
            }
            public class PhoneLines
            {
                public string lineType { get; set; }
                public PhoneInfo phoneInfo { get; set; }
                public class PhoneInfo
                {
                    public int? id { get; set; }
                    public Country country { get; set; }
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
                }
            }
            public class Shipping
            {
                public string status { get; set; }
                public string carrier { get; set; }
                public string trackingNumber { get; set; }
                public Method[] method { get; set; }
                public Address[] address { get; set; }
                public class Method
                {
                    public string id { get; set; }
                    public string name { get; set; }
                }
                public class Address
                {
                    public string customerName { get; set; }
                    public string street { get; set; }
                    public string street2 { get; set; }
                    public string city { get; set; }
                    public string state { get; set; }
                    public string zip { get; set; }
                    public string country { get; set; }
                }
            }
        }
    }
}
