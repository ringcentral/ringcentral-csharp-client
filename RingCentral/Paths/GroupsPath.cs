using System.Threading.Tasks;
namespace RingCentral
{
    public partial class GroupsPath : PathSegment
    {
        internal GroupsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "groups";
            }
        }
        public PostsPath Posts()
        {
            return new PostsPath(this);
        }
        public EventsPath Events(string _id)
        {
            return new EventsPath(this, _id);
        }
        public EventsPath Events()
        {
            return new EventsPath(this);
        }
        public NotesPath Notes(string _id)
        {
            return new NotesPath(this, _id);
        }
        public NotesPath Notes()
        {
            return new NotesPath(this);
        }
        public WebhooksPath Webhooks(string _id)
        {
            return new WebhooksPath(this, _id);
        }
        public WebhooksPath Webhooks()
        {
            return new WebhooksPath(this);
        }
    }
}
