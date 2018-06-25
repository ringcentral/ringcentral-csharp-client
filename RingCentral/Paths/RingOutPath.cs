using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RingOutPath : PathSegment
    {
        internal RingOutPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "ring-out";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.7 (Release 5.16)</p><p>Makes a 2-leg RingOut call.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>RingOut</td><td>Performing two-legged ring-out phone calls</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<GetRingOutStatusResponse> Post()
        {
            return RC.Post<GetRingOutStatusResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.7 (Release 5.16)</p><p>Makes a 2-leg RingOut call.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>RingOut</td><td>Performing two-legged ring-out phone calls</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<GetRingOutStatusResponse> Post(object parameters)
        {
            return RC.Post<GetRingOutStatusResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.7 (Release 5.16)</p><p>Makes a 2-leg RingOut call.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>RingOut</td><td>Performing two-legged ring-out phone calls</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<GetRingOutStatusResponse> Post(MakeRingOutRequest parameters)
        {
            return Post(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.7 (Release 5.16)</p><p>Returns the status of a 2-leg RingOut call.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>RingOut</td><td>Performing two-legged ring-out phone calls</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetRingOutStatusResponse> Get()
        {
            return RC.Get<GetRingOutStatusResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'></p><p>Cancels the 2-leg RingOut call.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>RingOut</td><td>Performing two-legged ring-out phone calls</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
