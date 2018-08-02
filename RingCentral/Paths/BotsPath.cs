using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BotsPath : PathSegment
    {
        internal BotsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "bots";
            }
        }
        // Creates a bot extension. Please note: Bot extension is always created in Enabled status, no welcome email is sent.
        public Task<BotExtensionCreation> Post()
        {
            return RC.Post<BotExtensionCreation>(Endpoint(true), null);
        }
        // Creates a bot extension. Please note: Bot extension is always created in Enabled status, no welcome email is sent.
        public Task<BotExtensionCreation> Post(object parameters)
        {
            return RC.Post<BotExtensionCreation>(Endpoint(true), parameters);
        }
        // Creates a bot extension. Please note: Bot extension is always created in Enabled status, no welcome email is sent.
        public Task<BotExtensionCreation> Post(BotExtensionCreationRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
