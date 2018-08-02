using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LicensesPath : PathSegment
    {
        internal LicensesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "licenses";
            }
        }
        public BulkPurchasePath BulkPurchase()
        {
            return new BulkPurchasePath(this);
        }
        // Returns list of licenses for a specific user.
        public Task<LicenseList> List()
        {
            return RC.Get<LicenseList>(Endpoint(false), null);
        }
        // Returns list of licenses for a specific user.
        public Task<LicenseList> List(object parameters)
        {
            return RC.Get<LicenseList>(Endpoint(false), parameters);
        }
        // Returns list of licenses for a specific user.
        public Task<LicenseList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // Internal identifier of a license type. If not specified account licenses of all types are returned
            public long? @typeId { get; set; }
        }
        // Returns license information by its ID.
        public Task<LicenseInfo> Get()
        {
            return RC.Get<LicenseInfo>(Endpoint(true), null);
        }
        // Removes a license for a specific user. Please note: It is not allowed to remove assigned licenses (only Webinars and Large Meetings can be assigned).
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
