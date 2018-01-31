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
        // <p style='font-style:italic;'>Since 8.2 (Release 1.0.26)</p><p>Returns a list of predefined standard greetings. Please note: Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>View Greetings</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<DictionaryGreetingList> List()
        {
            return RC.Get<DictionaryGreetingList>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 8.2 (Release 1.0.26)</p><p>Returns a list of predefined standard greetings. Please note: Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>View Greetings</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<DictionaryGreetingList> List(object parameters)
        {
            return RC.Get<DictionaryGreetingList>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 8.2 (Release 1.0.26)</p><p>Returns a list of predefined standard greetings. Please note: Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>View Greetings</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<DictionaryGreetingList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
            // Type of a greeting, specifying the case when the greeting is played
            public string @type { get; set; }
            // Usage type of a greeting, specifying if the greeting is applied for user extension or department extension
            public string @usageType { get; set; }
        }
        // <p style='font-style:italic;'>Since 8.2 (Release 1.0.26)</p><p>Returns a standard greeting by ID</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>View Greetings</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<DictionaryGreetingInfo> Get()
        {
            return RC.Get<DictionaryGreetingInfo>(Endpoint(true), null);
        }
        //
        public Task<CustomCompanyGreetingInfo> Post()
        {
            return RC.Post<CustomCompanyGreetingInfo>(Endpoint(true), null);
        }
        //
        public Task<CustomCompanyGreetingInfo> Post(object parameters)
        {
            return RC.Post<CustomCompanyGreetingInfo>(Endpoint(true), parameters);
        }
        //
        public Task<CustomCompanyGreetingInfo> Post(CustomGreetingRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
