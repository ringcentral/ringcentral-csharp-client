using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AddressBookPath : PathSegment
    {
        internal AddressBookPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
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
    }
}
