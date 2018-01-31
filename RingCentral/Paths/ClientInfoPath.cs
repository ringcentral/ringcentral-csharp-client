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
        public BannersPath Banners()
        {
            return new BannersPath(this);
        }
        public CustomDataPath CustomData(string _id)
        {
            return new CustomDataPath(this, _id);
        }
        public SpecialNumberRulePath SpecialNumberRule()
        {
            return new SpecialNumberRulePath(this);
        }
    }
}
