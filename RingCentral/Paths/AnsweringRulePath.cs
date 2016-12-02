using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AnsweringRulePath : PathSegment
    {
        internal AnsweringRulePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "answering-rule";
            }
        }
        // Create Custom Answering Rule
        public Task<AnsweringRuleInfo> Post()
        {
            return RC.Post<AnsweringRuleInfo>(Endpoint(true), null);
        }
        // Create Custom Answering Rule
        public Task<AnsweringRuleInfo> Post(object parameters)
        {
            return RC.Post<AnsweringRuleInfo>(Endpoint(true), parameters);
        }
        // Create Custom Answering Rule
        public Task<AnsweringRuleInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Specifies if the rule is active or inactive. The default value is 'True'
            public bool? @enabled { get; set; }
            // Type of an answering rule, the supported value is 'Custom'
            public string @type { get; set; }
            // Name of an answering rule specified by user. Max number of symbols is 30
            public string @name { get; set; }
            // Answering rule will be applied when calls are received from the specified caller(s)
            public CallersInfo[] @callers { get; set; }
            // Answering rule will be applied when calling the specified number(s)
            public CalledNumberInfo[] @calledNumbers { get; set; }
            // Schedule when an answering rule should be applied
            public AnsweringRule_ScheduleInfo @schedule { get; set; }
            // Specifies how incoming calls should be forwarded. The default value is 'ForwardCalls'
            public string @callHandlingAction { get; set; }
            // Forwarding parameters. If the 'callHandlingAction' parameter value is set to 'ForwardCalls' - should be specified . The settings determine the forwarding numbers to which the call should be forwarded. If not specified in request, then the business-hours forwarding rules are set by default
            public ForwardingInfo @forwarding { get; set; }
            // Unconditional forwarding parameters. If the 'callHandlingAction' parameter value is set to 'UnconditionalForwarding' - should be specified
            public UnconditionalForwardingInfo @unconditionalForwarding { get; set; }
            // Specifies whether to take a voicemail and who should do it
            public VoicemailInfo @voiceMail { get; set; }
        }
        // Get Answering Rules List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // Canonical URI of an answering rule resource
            public string @uri { get; set; }
            // List of answering rules
            public AnsweringRuleInfo[] @records { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
        }
        // Delete Answering Rule by ID
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Get Custom Answering Rule by ID
        public Task<AnsweringRuleInfo> Get()
        {
            return RC.Get<AnsweringRuleInfo>(Endpoint(true), null);
        }
        // Update Answering Rule by ID
        public Task<AnsweringRuleInfo> Put()
        {
            return RC.Put<AnsweringRuleInfo>(Endpoint(true), null);
        }
        // Update Answering Rule by ID
        public Task<AnsweringRuleInfo> Put(object parameters)
        {
            return RC.Put<AnsweringRuleInfo>(Endpoint(true), parameters);
        }
        // Update Answering Rule by ID
        public Task<AnsweringRuleInfo> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // Specifies if the answering rule is active or not
            public bool? @enabled { get; set; }
            // Custom name of an answering rule. The maximum number of characters is 64
            public string @name { get; set; }
            // Forwarding parameters. Returned if 'ForwardCalls' is specified in 'callHandlingAction'. These settings determine the forwarding numbers to which the call will be forwarded
            public ForwardingInfo @forwarding { get; set; }
            // Predefined greetings applied for an answering rule
            public GreetingInfo[] @greetings { get; set; }
        }
    }
}
