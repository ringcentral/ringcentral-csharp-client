
namespace RingCentral
{
    public partial class AddressBook : Model
    {
        internal AddressBook(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "address-book";
            }
        }
        public Contact Contact(ID _id)
        {
            return new Contact(this, _id);
        }
        public Contact Contact()
        {
            return new Contact(this, null);
        }
        public Group Group(ID _id)
        {
            return new Group(this, _id);
        }
        public Group Group()
        {
            return new Group(this, null);
        }
    }
}
