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
        //
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
        //
        public async Task<bool> Get(object parameters)
        {
            await RC.Get(Endpoint(true), parameters);
            return true;
        }
        //
        public Task<bool> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
    }
}
