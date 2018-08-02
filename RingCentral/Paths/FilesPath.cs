using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FilesPath : PathSegment
    {
        internal FilesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "files";
            }
        }
        // Posts a file.
        public Task<PostGlipFile> Post()
        {
            return RC.Post<PostGlipFile>(Endpoint(true), null);
        }
        // Posts a file.
        public Task<PostGlipFile> Post(object parameters)
        {
            return RC.Post<PostGlipFile>(Endpoint(true), parameters);
        }
        // Posts a file.
        public Task<PostGlipFile> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Internal identifier of a group to which the post with attachement will be added to
            public long? @groupId { get; set; }
            // Name of a file attached
            public string @name { get; set; }
        }
    }
}
