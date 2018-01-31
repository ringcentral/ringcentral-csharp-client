using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ParkLocationsPath : PathSegment
    {
        internal ParkLocationsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "park-locations";
            }
        }
        public UsersPath Users()
        {
            return new UsersPath(this);
        }
        public BulkAssignPath BulkAssign()
        {
            return new BulkAssignPath(this);
        }
    }
}
