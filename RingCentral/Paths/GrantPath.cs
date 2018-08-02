using System.Threading.Tasks;
namespace RingCentral
{
    public partial class GrantPath : PathSegment
    {
        internal GrantPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "grant";
            }
        }
        // Returns the list of extension grants.
        public Task<GetExtensionGrantListResponse> List()
        {
            return RC.Get<GetExtensionGrantListResponse>(Endpoint(false), null);
        }
        // Returns the list of extension grants.
        public Task<GetExtensionGrantListResponse> List(object parameters)
        {
            return RC.Get<GetExtensionGrantListResponse>(Endpoint(false), parameters);
        }
        // Returns the list of extension grants.
        public Task<GetExtensionGrantListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            //
            public string @page { get; set; }
            //
            public string @perPage { get; set; }
        }
    }
}
