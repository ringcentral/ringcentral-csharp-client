using System.Threading.Tasks;
namespace RingCentral
{
    public partial class TransferPath : PathSegment
    {
        internal TransferPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "transfer";
            }
        }
        // Transfers a party by placing a new call to the specified target
        public Task<CallParty> Post()
        {
            return RC.Post<CallParty>(Endpoint(true), null);
        }
        // Transfers a party by placing a new call to the specified target
        public Task<CallParty> Post(object parameters)
        {
            return RC.Post<CallParty>(Endpoint(true), parameters);
        }
        // Transfers a party by placing a new call to the specified target
        public Task<CallParty> Post(TransferTarget parameters)
        {
            return Post(parameters as object);
        }
    }
}
