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
        // Returns the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
        // Updates the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).**Please note**: currently personal address book size is limited to 10 000 contacts.
        public async Task<bool> Put()
        {
            await RC.Put(Endpoint(true), null);
            return true;
        }
        // Updates the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).**Please note**: currently personal address book size is limited to 10 000 contacts.
        public async Task<bool> Put(object parameters)
        {
            await RC.Put(Endpoint(true), parameters);
            return true;
        }
        // Updates the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).**Please note**: currently personal address book size is limited to 10 000 contacts.
        public Task<bool> Put(FavoriteCollection parameters)
        {
            return Put(parameters as object);
        }
    }
}
