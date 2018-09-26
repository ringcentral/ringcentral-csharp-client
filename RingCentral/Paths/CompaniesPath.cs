using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CompaniesPath : PathSegment
    {
        internal CompaniesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "companies";
            }
        }
        // Returns information about a company or multiple companies by ID(s)
        public Task<GlipCompany> Get()
        {
            return RC.Get<GlipCompany>(Endpoint(true), null);
        }
    }
}
