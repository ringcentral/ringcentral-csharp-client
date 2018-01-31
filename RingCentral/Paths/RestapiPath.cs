using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RestapiPath : PathSegment
    {
        internal RestapiPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "restapi";
            }
        }
        public StatusPath Status()
        {
            return new StatusPath(this);
        }
        public AccountPath Account(string _id)
        {
            return new AccountPath(this, _id);
        }
        public AccountPath Account()
        {
            return new AccountPath(this, "~");
        }
        public DictionaryPath Dictionary()
        {
            return new DictionaryPath(this);
        }
        public GlipPath Glip()
        {
            return new GlipPath(this);
        }
        public SubscriptionPath Subscription(string _id)
        {
            return new SubscriptionPath(this, _id);
        }
        public SubscriptionPath Subscription()
        {
            return new SubscriptionPath(this);
        }
        public ClientInfoPath ClientInfo()
        {
            return new ClientInfoPath(this);
        }
        public NumberParserPath NumberParser()
        {
            return new NumberParserPath(this);
        }
        public NumberPoolPath NumberPool()
        {
            return new NumberPoolPath(this);
        }
        public ScimPath Scim()
        {
            return new ScimPath(this);
        }
        // <p style='font-style:italic;'>Since 1.0.0</p><p>Returns current API version(s) and server info.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetVersionsResponse> List()
        {
            return RC.Get<GetVersionsResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.0</p><p>Returns current API version info by apiVersion.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetVersionResponse> Get()
        {
            return RC.Get<GetVersionResponse>(Endpoint(true), null);
        }
    }
}
