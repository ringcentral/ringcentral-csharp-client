
namespace RingCentral
{
    public partial class ClientInfo : Model
    {
        internal ClientInfo(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "client-info";
            }
        }
        public CustomData CustomData(string _id = null)
        {
            return new CustomData(this, _id);
        }
    }
}
