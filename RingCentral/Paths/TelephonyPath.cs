using System.Threading.Tasks;
namespace RingCentral
{
    public partial class TelephonyPath : PathSegment
    {
        internal TelephonyPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "telephony";
            }
        }
        public SessionsPath Sessions(string _id)
        {
            return new SessionsPath(this, _id);
        }
    }
}
