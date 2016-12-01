using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ClientInfoPath : Model
    {
        internal ClientInfoPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
