using System.Threading.Tasks;
namespace RingCentral
{
    public partial class UnholdPath : PathSegment
    {
        internal UnholdPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "unhold";
            }
        }
        // Brings a party back into a call and stops to play Hold Music. There is a known limitation for Hold API - hold via REST API doesn't work with hold placed via RingCentral apps or HardPhone. It means that if you muted participant via Call Control API and RingCentral Desktop app, then you need to unhold both endpoints to remove Hold Music and bring media back.
        public Task<CallParty> Post()
        {
            return RC.Post<CallParty>(Endpoint(true), null);
        }
    }
}
