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
        // Returns the extension answering rules.
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
        // Returns the extension answering rules.
        public async Task<bool> Get(object parameters)
        {
            await RC.Get(Endpoint(true), parameters);
            return true;
        }
        // Returns the extension answering rules.
        public Task<bool> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            //
            public string @page { get; set; }
            //
            public string @perPage { get; set; }
        }
        // Creates a custom answering rule for a particular caller ID.
        public Task<AnsweringRuleInfo> Post()
        {
            return RC.Post<AnsweringRuleInfo>(Endpoint(true), null);
        }
        // Creates a custom answering rule for a particular caller ID.
        public Task<AnsweringRuleInfo> Post(object parameters)
        {
            return RC.Post<AnsweringRuleInfo>(Endpoint(true), parameters);
        }
        // Creates a custom answering rule for a particular caller ID.
        public Task<AnsweringRuleInfo> Post(CreateAnsweringRuleRequest parameters)
        {
            return Post(parameters as object);
        }
        // Updates a custom answering rule for a particular caller ID.
        public Task<AnsweringRuleInfo> Put()
        {
            return RC.Put<AnsweringRuleInfo>(Endpoint(true), null);
        }
        // Updates a custom answering rule for a particular caller ID.
        public Task<AnsweringRuleInfo> Put(object parameters)
        {
            return RC.Put<AnsweringRuleInfo>(Endpoint(true), parameters);
        }
        // Updates a custom answering rule for a particular caller ID.
        public Task<AnsweringRuleInfo> Put(UpdateAnsweringRuleRequest parameters)
        {
            return Put(parameters as object);
        }
        // Deletes a custom answering rule by a particular ID.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Returns a list of company answering rules.
        public Task<CompanyAnsweringRuleList> List()
        {
            return RC.Get<CompanyAnsweringRuleList>(Endpoint(false), null);
        }
    }
}
