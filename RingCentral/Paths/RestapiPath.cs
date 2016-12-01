using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RestapiPath : Model
    {
        internal RestapiPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "restapi";
            }
        }
        public OauthPath Oauth()
        {
            return new OauthPath(this);
        }
        public AccountPath Account(string _id)
        {
            return new AccountPath(this, _id);
        }
        public AccountPath Account()
        {
            return new AccountPath(this, "~");
        }
        public ClientInfoPath ClientInfo()
        {
            return new ClientInfoPath(this);
        }
        public DictionaryPath Dictionary()
        {
            return new DictionaryPath(this);
        }
        public NumberParserPath NumberParser()
        {
            return new NumberParserPath(this);
        }
        public NumberPoolPath NumberPool()
        {
            return new NumberPoolPath(this);
        }
        public SubscriptionPath Subscription(string _id)
        {
            return new SubscriptionPath(this, _id);
        }
        public SubscriptionPath Subscription()
        {
            return new SubscriptionPath(this);
        }
        // Get Server Info
        public Task<ServerInfo> List()
        {
            return RC.Get<ServerInfo>(Endpoint(false), null);
        }
        // Get API Version Info
        public Task<VersionInfo> Get()
        {
            return RC.Get<VersionInfo>(Endpoint(true), null);
        }
    }
}
