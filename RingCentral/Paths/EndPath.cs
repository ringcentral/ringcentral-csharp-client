using System.Threading.Tasks;
namespace RingCentral
{
    public partial class EndPath : Model
    {
        internal EndPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "end";
            }
        }
        // End Current Meeting
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
    }
}
