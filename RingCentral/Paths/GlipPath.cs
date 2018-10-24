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
        public ChatsPath Chats(string _id)
        {
            return new ChatsPath(this, _id);
        }
        public ChatsPath Chats()
        {
            return new ChatsPath(this);
        }
        public ConversationsPath Conversations(string _id)
        {
            return new ConversationsPath(this, _id);
        }
        public ConversationsPath Conversations()
        {
            return new ConversationsPath(this);
        }
        public TeamsPath Teams(string _id)
        {
            return new TeamsPath(this, _id);
        }
        public TeamsPath Teams()
        {
            return new TeamsPath(this);
        }
        public EveryonePath Everyone()
        {
            return new EveryonePath(this);
        }
        public GroupsPath Groups(string _id)
        {
            return new GroupsPath(this, _id);
        }
        public FilesPath Files()
        {
            return new FilesPath(this);
        }
        public CardsPath Cards(string _id)
        {
            return new CardsPath(this, _id);
        }
        public CardsPath Cards()
        {
            return new CardsPath(this);
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
        public PersonsPath Persons(string _id)
        {
            return new PersonsPath(this, _id);
        }
        public CompaniesPath Companies(string _id)
        {
            return new CompaniesPath(this, _id);
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
