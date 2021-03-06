using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallLogSyncPath : PathSegment
    {
        internal CallLogSyncPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "call-log-sync";
            }
        }
        // Synchronizes call log records
        public Task<CallLogSync> List()
        {
            return RC.Get<CallLogSync>(Endpoint(false), null);
        }
        // Synchronizes call log records
        public Task<CallLogSync> List(object parameters)
        {
            return RC.Get<CallLogSync>(Endpoint(false), parameters);
        }
        // Synchronizes call log records
        public Task<CallLogSync> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Type of synchronization
            public string[] @syncType { get; set; }
            // Value of syncToken property of last sync request response
            public string @syncToken { get; set; }
            // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment
            public string @dateFrom { get; set; }
            // For 'FSync' the parameter is mandatory, it limits the number of records to be returned in response. For 'ISync' it specifies with how many records to extend sync Frame to the past, the maximum number of records is 250
            public long? @recordCount { get; set; }
            // Type of calls to be returned. The default value is 'All'
            public string[] @statusGroup { get; set; }
            // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
            public string @view { get; set; }
        }
    }
}
