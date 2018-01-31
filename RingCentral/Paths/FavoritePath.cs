using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FavoritePath : PathSegment
    {
        internal FavoritePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "favorite";
            }
        }
        //
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
        //
        public async Task<bool> Put()
        {
            await RC.Put(Endpoint(true), null);
            return true;
        }
        //
        public async Task<bool> Put(object parameters)
        {
            await RC.Put(Endpoint(true), parameters);
            return true;
        }
        //
        public Task<bool> Put(FavoriteCollection parameters)
        {
            return Put(parameters as object);
        }
    }
}
