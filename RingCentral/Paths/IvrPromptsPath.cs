using System.Threading.Tasks;
namespace RingCentral
{
    public partial class IvrPromptsPath : PathSegment
    {
        internal IvrPromptsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "ivr-prompts";
            }
        }
        public ContentPath Content(string _id)
        {
            return new ContentPath(this, _id);
        }
        public ContentPath Content()
        {
            return new ContentPath(this);
        }
        // Creates an IVR prompt.
        public Task<PromptInfo> Post()
        {
            return RC.Post<PromptInfo>(Endpoint(true), null);
        }
        // Returns a list of IVR prompts.
        public Task<IVRPrompts> List()
        {
            return RC.Get<IVRPrompts>(Endpoint(false), null);
        }
        // Returns an IVR prompt by ID.
        public Task<PromptInfo> Get()
        {
            return RC.Get<PromptInfo>(Endpoint(true), null);
        }
        // Deletes an IVR prompt by ID.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
