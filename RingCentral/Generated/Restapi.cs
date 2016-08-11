
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Restapi : Model
    {
        internal Restapi(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "restapi";
            }
        }
        public Oauth Oauth()
        {
            return new Oauth(this);
        }
        public Account Account(ID _id)
        {
            return new Account(this, _id);
        }
        public Account Account()
        {
            return new Account(this, "~");
        }
        public ClientInfo ClientInfo()
        {
            return new ClientInfo(this);
        }
        public Dictionary Dictionary()
        {
            return new Dictionary(this);
        }
        public NumberParser NumberParser()
        {
            return new NumberParser(this);
        }
        public NumberPool NumberPool()
        {
            return new NumberPool(this);
        }
        public Subscription Subscription(ID _id)
        {
            return new Subscription(this, _id);
        }
        public Subscription Subscription()
        {
            return new Subscription(this, null);
        }
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // Canonical URI of the API version
            public string uri { get; set; }
            // Full API version information: uri, number, release date
            public VersionInfo[] apiVersions { get; set; }
            // Server version
            public string serverVersion { get; set; }
            // Server revision
            public string serverRevision { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Canonical URI of API versions
            public string uri { get; set; }
            // Version of the RingCentral REST API
            public string versionString { get; set; }
            // Release date of this version
            public string releaseDate { get; set; }
            // URI part determining the current version
            public string uriString { get; set; }
        }
    }
}
