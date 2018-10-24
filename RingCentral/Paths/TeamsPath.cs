using System.Threading.Tasks;
namespace RingCentral
{
    public partial class TeamsPath : PathSegment
    {
        internal TeamsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "teams";
            }
        }
        // Returns list of teams where user is participant.
        public Task<GlipTeamsList> List()
        {
            return RC.Get<GlipTeamsList>(Endpoint(false), null);
        }
        // Returns list of teams where user is participant.
        public Task<GlipTeamsList> List(object parameters)
        {
            return RC.Get<GlipTeamsList>(Endpoint(false), parameters);
        }
        // Returns list of teams where user is participant.
        public Task<GlipTeamsList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Max number of teams to be fetched by one request (Not more than 250).
            public double? @recordCount { get; set; }
            // Pagination token.
            public string @pageToken { get; set; }
        }
        // Returns information about a team by ID.
        public Task<GlipTeamInfo> Get()
        {
            return RC.Get<GlipTeamInfo>(Endpoint(true), null);
        }
    }
}
