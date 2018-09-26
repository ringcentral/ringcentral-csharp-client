using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CardsPath : PathSegment
    {
        internal CardsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "cards";
            }
        }
        // Creates a new message.
        public Task<GlipMessageAttachmentInfo> Post()
        {
            return RC.Post<GlipMessageAttachmentInfo>(Endpoint(true), null);
        }
        // Creates a new message.
        public Task<GlipMessageAttachmentInfo> Post(object parameters)
        {
            return RC.Post<GlipMessageAttachmentInfo>(Endpoint(true), parameters);
        }
        // Creates a new message.
        public Task<GlipMessageAttachmentInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Internal identifier of a group where to create a post with the card
            public long? @groupId { get; set; }
        }
        // Returns card(s) with given id(s).
        public Task<GlipMessageAttachmentInfo> Get()
        {
            return RC.Get<GlipMessageAttachmentInfo>(Endpoint(true), null);
        }
        // Updates a card
        public async Task<bool> Put()
        {
            await RC.Put(Endpoint(true), null);
            return true;
        }
        // Updates a card
        public async Task<bool> Put(object parameters)
        {
            await RC.Put(Endpoint(true), parameters);
            return true;
        }
        // Updates a card
        public Task<bool> Put(GlipMessageAttachmentInfoRequest parameters)
        {
            return Put(parameters as object);
        }
        // Deletes a card by ID.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
