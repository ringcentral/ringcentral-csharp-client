using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DirectoryPath : PathSegment
    {
        internal DirectoryPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "directory";
            }
        }
        public ContactsPath Contacts(string _id)
        {
            return new ContactsPath(this, _id);
        }
        public ContactsPath Contacts()
        {
            return new ContactsPath(this);
        }
        public FederationPath Federation()
        {
            return new FederationPath(this);
        }
        public FederationConflictsPath FederationConflicts()
        {
            return new FederationConflictsPath(this);
        }
        public ExtensionNumbersPath ExtensionNumbers()
        {
            return new ExtensionNumbersPath(this);
        }
    }
}
