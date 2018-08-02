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
        // Returns supported license types.
        public Task<LicenseTypes> List()
        {
            return RC.Get<LicenseTypes>(Endpoint(false), null);
        }
    }
}
