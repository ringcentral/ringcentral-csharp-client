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
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns a company by ID.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipCompany> Get()
        {
            return RC.Get<GlipCompany>(Endpoint(true), null);
        }
    }
}
