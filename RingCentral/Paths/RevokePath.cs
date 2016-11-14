using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RevokePath : Model
    {
        internal RevokePath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "revoke";
            }
        }
        // OAuth2 Revoke Token
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
        // OAuth2 Revoke Token
        public async Task<bool> Post(object parameters)
        {
            await RC.Post(Endpoint(true), parameters);
            return true;
        }
        // OAuth2 Revoke Token
        public Task<bool> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Active access or refresh token to be revoked
            public string @token { get; set; }
        }
    }
}
