using System.Threading.Tasks;
namespace RingCentral
{
    public partial class NotesPath : PathSegment
    {
        internal NotesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "notes";
            }
        }
        public LockPath Lock()
        {
            return new LockPath(this);
        }
        public PublishPath Publish()
        {
            return new PublishPath(this);
        }
        public UnlockPath Unlock()
        {
            return new UnlockPath(this);
        }
        // Returns the list of group notes.
        public Task<GlipNotesInfo> List()
        {
            return RC.Get<GlipNotesInfo>(Endpoint(false), null);
        }
        // Returns the list of group notes.
        public Task<GlipNotesInfo> List(object parameters)
        {
            return RC.Get<GlipNotesInfo>(Endpoint(false), parameters);
        }
        // Returns the list of group notes.
        public Task<GlipNotesInfo> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Max number of groups to be fetched by one request (Not more than 250)
            public double? @recordCount { get; set; }
            // Pagination token
            public string @pageToken { get; set; }
            // Status of notes to be fetched. If not specified all notes are returned
            public string @status { get; set; }
            // Internal identifier of a note author
            public string @creatorId { get; set; }
        }
        // Creates a new note in a group.
        public Task<GlipNoteInfo> Post()
        {
            return RC.Post<GlipNoteInfo>(Endpoint(true), null);
        }
        // Creates a new note in a group.
        public Task<GlipNoteInfo> Post(object parameters)
        {
            return RC.Post<GlipNoteInfo>(Endpoint(true), parameters);
        }
        // Creates a new note in a group.
        public Task<GlipNoteInfo> Post(GlipNoteCreate parameters)
        {
            return Post(parameters as object);
        }
        // Deletes a note with the specified ID.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
