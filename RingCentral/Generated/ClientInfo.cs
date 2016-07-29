
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
        public CustomData CustomData(ID _id)
        {
            return new CustomData(this, _id);
        }
        public CustomData CustomData()
        {
            return new CustomData(this, null);
        }
    }
}
