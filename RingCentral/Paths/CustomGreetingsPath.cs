using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CustomGreetingsPath : PathSegment
    {
        internal CustomGreetingsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "custom-greetings";
            }
        }
        // Returns call recording custom greetings.
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
        // Deletes call recording custom greetings.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
