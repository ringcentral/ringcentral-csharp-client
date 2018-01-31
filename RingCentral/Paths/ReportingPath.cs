using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ReportingPath : PathSegment
    {
        internal ReportingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "reporting";
            }
        }
        public SettingsPath Settings()
        {
            return new SettingsPath(this);
        }
    }
}
