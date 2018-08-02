using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ClientInfoPath : PathSegment
    {
        internal ClientInfoPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "client-info";
            }
        }
        public SipProvisionPath SipProvision()
        {
            return new SipProvisionPath(this);
        }
    }
}
