using System.Threading.Tasks;
namespace RingCentral
{
    public partial class UsersPath : PathSegment
    {
        internal UsersPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "Users";
            }
        }
        //
        public Task<UserSearchResponse> Get()
        {
            return RC.Get<UserSearchResponse>(Endpoint(true), null);
        }
        //
        public Task<UserSearchResponse> Get(object parameters)
        {
            return RC.Get<UserSearchResponse>(Endpoint(true), parameters);
        }
        //
        public Task<UserSearchResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // only support 'userName' or 'email' filter expressions for now
            public string @filter { get; set; }
            // start index (1-based)
            public long? @startIndex { get; set; }
            // page size
            public long? @count { get; set; }
        }
        //
        public Task<UserResponse> Post()
        {
            return RC.Post<UserResponse>(Endpoint(true), null);
        }
        //
        public Task<UserResponse> Post(object parameters)
        {
            return RC.Post<UserResponse>(Endpoint(true), parameters);
        }
        //
        public Task<UserResponse> Post(User parameters)
        {
            return Post(parameters as object);
        }
        //
        public Task<UserResponse> Put()
        {
            return RC.Put<UserResponse>(Endpoint(true), null);
        }
        //
        public Task<UserResponse> Put(object parameters)
        {
            return RC.Put<UserResponse>(Endpoint(true), parameters);
        }
        //
        public Task<UserResponse> Put(User parameters)
        {
            return Put(parameters as object);
        }
        //
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
