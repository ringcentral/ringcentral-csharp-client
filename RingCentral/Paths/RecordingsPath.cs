using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RecordingsPath : PathSegment
    {
        internal RecordingsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "recordings";
            }
        }
        // Starts new call recording in a party
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
    }
}
