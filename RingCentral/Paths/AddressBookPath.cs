using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AddressBookPath : Model
    {
        internal AddressBookPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "address-book";
            }
        }
        public ContactPath Contact(string _id)
        {
            return new ContactPath(this, _id);
        }
        public ContactPath Contact()
        {
            return new ContactPath(this);
        }
        public GroupPath Group(string _id)
        {
            return new GroupPath(this, _id);
        }
        public GroupPath Group()
        {
            return new GroupPath(this);
        }
    }
}
