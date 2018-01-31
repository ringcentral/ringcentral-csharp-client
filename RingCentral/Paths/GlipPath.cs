using System.Threading.Tasks;
namespace RingCentral
{
    public partial class GlipPath : PathSegment
    {
        internal GlipPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "glip";
            }
        }
        public CompaniesPath Companies(string _id)
        {
            return new CompaniesPath(this, _id);
        }
        public GroupsPath Groups(string _id)
        {
            return new GroupsPath(this, _id);
        }
        public GroupsPath Groups()
        {
            return new GroupsPath(this);
        }
        public PersonsPath Persons(string _id)
        {
            return new PersonsPath(this, _id);
        }
        public PostsPath Posts()
        {
            return new PostsPath(this);
        }
        public FilesPath Files(string _id)
        {
            return new FilesPath(this, _id);
        }
        public FilesPath Files()
        {
            return new FilesPath(this);
        }
        public ProfilePath Profile()
        {
            return new ProfilePath(this);
        }
    }
}
