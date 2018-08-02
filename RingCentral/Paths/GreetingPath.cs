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
        // Returns a list of predefined standard greetings. Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.
        public Task<DictionaryGreetingList> List()
        {
            return RC.Get<DictionaryGreetingList>(Endpoint(false), null);
        }
        // Returns a list of predefined standard greetings. Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.
        public Task<DictionaryGreetingList> List(object parameters)
        {
            return RC.Get<DictionaryGreetingList>(Endpoint(false), parameters);
        }
        // Returns a list of predefined standard greetings. Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.
        public Task<DictionaryGreetingList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted.
            public long? @page { get; set; }
            // Indicates the page size (number of items).
            public long? @perPage { get; set; }
            // Type of a greeting, specifying the case when the greeting is played
            public string @type { get; set; }
            // Usage type of a greeting, specifying if the greeting is applied for user extension or department extension
            public string @usageType { get; set; }
        }
        // Returns a standard greeting by ID.
        public Task<DictionaryGreetingInfo> Get()
        {
            return RC.Get<DictionaryGreetingInfo>(Endpoint(true), null);
        }
        // Creates a custom company greeting.
        public Task<CustomCompanyGreetingInfo> Post()
        {
            return RC.Post<CustomCompanyGreetingInfo>(Endpoint(true), null);
        }
        // Creates a custom company greeting.
        public Task<CustomCompanyGreetingInfo> Post(object parameters)
        {
            return RC.Post<CustomCompanyGreetingInfo>(Endpoint(true), parameters);
        }
        // Creates a custom company greeting.
        public Task<CustomCompanyGreetingInfo> Post(CustomCompanyGreetingRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
