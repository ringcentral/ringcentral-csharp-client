using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LicenseTypesPath : PathSegment
    {
        internal LicenseTypesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "license-types";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Returns supported license types.</p><h4>API Group</h4><p>Light</p>
        public Task<LicenseTypes> List()
        {
            return RC.Get<LicenseTypes>(Endpoint(false), null);
        }
    }
}
