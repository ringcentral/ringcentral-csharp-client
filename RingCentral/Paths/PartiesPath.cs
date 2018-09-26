using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PartiesPath : PathSegment
    {
        internal PartiesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "parties";
            }
        }
        public HoldPath Hold()
        {
            return new HoldPath(this);
        }
        public UnholdPath Unhold()
        {
            return new UnholdPath(this);
        }
        public RejectPath Reject()
        {
            return new RejectPath(this);
        }
        public TransferPath Transfer()
        {
            return new TransferPath(this);
        }
        public ForwardPath Forward()
        {
            return new ForwardPath(this);
        }
        public FlipPath Flip()
        {
            return new FlipPath(this);
        }
        public RecordingsPath Recordings()
        {
            return new RecordingsPath(this);
        }
        // Returns a party status of a call session by ID.
        public Task<CallParty> Get()
        {
            return RC.Get<CallParty>(Endpoint(true), null);
        }
    }
}
