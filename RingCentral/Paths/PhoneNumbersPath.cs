using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PhoneNumbersPath : PathSegment
    {
        internal PhoneNumbersPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "phone-numbers";
            }
        }
        // Returns the lists of blocked and allowed phone numbers.
        public Task<BlockedAllowedPhoneNumbersList> List()
        {
            return RC.Get<BlockedAllowedPhoneNumbersList>(Endpoint(false), null);
        }
        // Returns the lists of blocked and allowed phone numbers.
        public Task<BlockedAllowedPhoneNumbersList> List(object parameters)
        {
            return RC.Get<BlockedAllowedPhoneNumbersList>(Endpoint(false), parameters);
        }
        // Returns the lists of blocked and allowed phone numbers.
        public Task<BlockedAllowedPhoneNumbersList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            //
            public long? @page { get; set; }
            //
            public long? @perPage { get; set; }
            //
            public string @status { get; set; }
        }
        // Updates either blocked or allowed phone number list with a new phone number.
        public Task<BlockedAllowedPhoneNumberInfo> Post()
        {
            return RC.Post<BlockedAllowedPhoneNumberInfo>(Endpoint(true), null);
        }
        // Updates either blocked or allowed phone number list with a new phone number.
        public Task<BlockedAllowedPhoneNumberInfo> Post(object parameters)
        {
            return RC.Post<BlockedAllowedPhoneNumberInfo>(Endpoint(true), parameters);
        }
        // Updates either blocked or allowed phone number list with a new phone number.
        public Task<BlockedAllowedPhoneNumberInfo> Post(AddBlockedAllowedPhoneNumber parameters)
        {
            return Post(parameters as object);
        }
        // Returns blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        public Task<BlockedAllowedPhoneNumberInfo> Get()
        {
            return RC.Get<BlockedAllowedPhoneNumberInfo>(Endpoint(true), null);
        }
        // Deletes blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Updates blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        public async Task<bool> Put()
        {
            await RC.Put(Endpoint(true), null);
            return true;
        }
    }
}
