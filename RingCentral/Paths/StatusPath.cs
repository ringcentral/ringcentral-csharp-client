using System.Threading.Tasks;
namespace RingCentral
{
    public partial class StatusPath : PathSegment
    {
        internal StatusPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "status";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.27 (Release 8.3)</p><p>Returns the API status; status '200' means the API is working fine, and '503' means it is temporary unavailable.</p><h4>API Group</h4><p>Light</p>
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
    }
}
