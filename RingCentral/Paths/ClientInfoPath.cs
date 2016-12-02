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
        public CustomDataPath CustomData(string _id)
        {
            return new CustomDataPath(this, _id);
        }
    }
}
