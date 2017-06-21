using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PersonsPath : PathSegment
    {
        internal PersonsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "persons";
            }
        }
        // Get Person by ID
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of a user
            public string @id { get; set; }
            // First name of a user
            public string @firstName { get; set; }
            // Last name of a user
            public string @lastName { get; set; }
            // Email of a user
            public string @email { get; set; }
            // Photo of a user
            public string @avatar { get; set; }
            // Internal identifier of a company
            public string @companyId { get; set; }
            // Time of creation in ISO 8601 format
            public string @creationTime { get; set; }
            // Time of last modification in ISO 8601 format
            public string @lastModifiedTime { get; set; }
        }
    }
}
