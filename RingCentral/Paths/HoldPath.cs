using System.Threading.Tasks;
namespace RingCentral
{
    public partial class HoldPath : PathSegment
    {
        internal HoldPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "hold";
            }
        }
        // Puts the party to stand-alone mode and starts to play Hold Music according to configuration & state to peers. There is a known limitation for Hold API - hold via REST API doesn't work with hold placed via RingCentral apps or HardPhone. It means that if you muted participant via Call Control API and RingCentral Desktop app, then you need to unhold both endpoints to remove Hold Music and bring media back.
        public Task<CallParty> Post()
        {
            return RC.Post<CallParty>(Endpoint(true), null);
        }
    }
}
