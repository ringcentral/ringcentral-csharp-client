using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ForwardPath : PathSegment
    {
        internal ForwardPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "forward";
            }
        }
        // Distributes a non-answered call to the defined target. Applicable for "Setup" or "Proceeding" states
        public Task<CallParty> Post()
        {
            return RC.Post<CallParty>(Endpoint(true), null);
        }
        // Distributes a non-answered call to the defined target. Applicable for "Setup" or "Proceeding" states
        public Task<CallParty> Post(object parameters)
        {
            return RC.Post<CallParty>(Endpoint(true), parameters);
        }
        // Distributes a non-answered call to the defined target. Applicable for "Setup" or "Proceeding" states
        public Task<CallParty> Post(ForwardTarget parameters)
        {
            return Post(parameters as object);
        }
    }
}
