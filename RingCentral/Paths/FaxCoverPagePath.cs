using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FaxCoverPagePath : PathSegment
    {
        internal FaxCoverPagePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "fax-cover-page";
            }
        }
        // Returns fax cover pages available for the current extension.
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
        // Returns fax cover pages available for the current extension.
        public async Task<bool> Get(object parameters)
        {
            await RC.Get(Endpoint(true), parameters);
            return true;
        }
        // Returns fax cover pages available for the current extension.
        public Task<bool> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
        }
    }
}
