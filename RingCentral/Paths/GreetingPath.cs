using System.Threading.Tasks;
namespace RingCentral
{
    public partial class GreetingPath : PathSegment
    {
        internal GreetingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "greeting";
            }
        }
        // Create Custom Greeting
        public Task<CustomGreetingInfo> Post()
        {
            return RC.Post<CustomGreetingInfo>(Endpoint(true), null);
        }
        // Create Custom Greeting
        public Task<CustomGreetingInfo> Post(object parameters)
        {
            return RC.Post<CustomGreetingInfo>(Endpoint(true), parameters);
        }
        // Create Custom Greeting
        public Task<CustomGreetingInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Type of a greeting, specifying the case when the greeting is played. See also Greeting Types
            public string @type { get; set; }
            // Information on an answering rule that the greeting is applied to
            public CustomGreetingInfo_AnsweringRuleInfo @answeringRule { get; set; }
        }
        // Get Custom Greeting by ID
        public Task<CustomGreetingInfo> Get()
        {
            return RC.Get<CustomGreetingInfo>(Endpoint(true), null);
        }
    }
}
