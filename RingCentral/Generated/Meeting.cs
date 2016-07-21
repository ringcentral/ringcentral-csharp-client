
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Meeting : Model
    {
        internal Meeting(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "meeting";
            }
        }
        public ServiceInfo ServiceInfo()
        {
            return new ServiceInfo(this);
        }
        public End End()
        {
            return new End(this);
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public class PostRequest
        {
            public string topic { get; set; }
            public string meetingType { get; set; }
            public string password { get; set; }
            public Schedule schedule { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public bool? startHostVideo { get; set; }
            public bool? startParticipantsVideo { get; set; }
            public string[] audioOptions { get; set; }
            public class Schedule
            {
                public string startTime { get; set; }
                public int? durationInMinutes { get; set; }
                public TimeZone timeZone { get; set; }
                public class TimeZone
                {
                    public string id { get; set; }
                }
            }
        }
        public class PostResponse
        {
            public string uri { get; set; }
            public string id { get; set; }
            public string topic { get; set; }
            public string meetingType { get; set; }
            public string password { get; set; }
            public string status { get; set; }
            public Links links { get; set; }
            public Schedule schedule { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public bool? startHostVideo { get; set; }
            public bool? startParticipantsVideo { get; set; }
            public string[] audioOptions { get; set; }
            public class Links
            {
                public string startUri { get; set; }
                public string joinUri { get; set; }
            }
            public class Schedule
            {
                public string startTime { get; set; }
                public int? durationInMinutes { get; set; }
                public TimeZone timeZone { get; set; }
                public class TimeZone
                {
                    public string id { get; set; }
                }
            }
        }
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public class ListResponse
        {
            public string uri { get; set; }
            public Record[] records { get; set; }
            public Paging paging { get; set; }
            public Navigation navigation { get; set; }
            public class Record
            {
                public string uri { get; set; }
                public string id { get; set; }
                public string topic { get; set; }
                public string meetingType { get; set; }
                public string password { get; set; }
                public string status { get; set; }
                public Links links { get; set; }
                public Schedule schedule { get; set; }
                public bool? allowJoinBeforeHost { get; set; }
                public bool? startHostVideo { get; set; }
                public bool? startParticipantsVideo { get; set; }
                public string[] audioOptions { get; set; }
                public class Links
                {
                    public string startUri { get; set; }
                    public string joinUri { get; set; }
                }
                public class Schedule
                {
                    public string startTime { get; set; }
                    public int? durationInMinutes { get; set; }
                    public TimeZone timeZone { get; set; }
                    public class TimeZone
                    {
                        public string id { get; set; }
                    }
                }
            }
            public class Paging
            {
                public int? page { get; set; }
                public int? perPage { get; set; }
                public int? pageStart { get; set; }
                public int? pageEnd { get; set; }
                public int? totalPages { get; set; }
                public int? totalElements { get; set; }
            }
            public class Navigation
            {
                public FirstPage firstPage { get; set; }
                public NextPage nextPage { get; set; }
                public PreviousPage previousPage { get; set; }
                public LastPage lastPage { get; set; }
                public class FirstPage
                {
                    public string uri { get; set; }
                }
                public class NextPage
                {
                    public string uri { get; set; }
                }
                public class PreviousPage
                {
                    public string uri { get; set; }
                }
                public class LastPage
                {
                    public string uri { get; set; }
                }
            }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string uri { get; set; }
            public string id { get; set; }
            public string topic { get; set; }
            public string meetingType { get; set; }
            public string password { get; set; }
            public string status { get; set; }
            public Links links { get; set; }
            public Schedule schedule { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public bool? startHostVideo { get; set; }
            public bool? startParticipantsVideo { get; set; }
            public string[] audioOptions { get; set; }
            public class Links
            {
                public string startUri { get; set; }
                public string joinUri { get; set; }
            }
            public class Schedule
            {
                public string startTime { get; set; }
                public int? durationInMinutes { get; set; }
                public TimeZone timeZone { get; set; }
                public class TimeZone
                {
                    public string id { get; set; }
                }
            }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public class PutRequest
        {
            public string topic { get; set; }
            public string meetingType { get; set; }
            public string password { get; set; }
            public Schedule schedule { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public bool? startHostVideo { get; set; }
            public bool? startParticipantsVideo { get; set; }
            public string[] audioOptions { get; set; }
            public class Schedule
            {
                public string startTime { get; set; }
                public int? durationInMinutes { get; set; }
                public TimeZone timeZone { get; set; }
                public class TimeZone
                {
                    public string id { get; set; }
                }
            }
        }
        public class PutResponse
        {
            public string uri { get; set; }
            public string id { get; set; }
            public string topic { get; set; }
            public string meetingType { get; set; }
            public string password { get; set; }
            public string status { get; set; }
            public Links links { get; set; }
            public Schedule schedule { get; set; }
            public bool? allowJoinBeforeHost { get; set; }
            public bool? startHostVideo { get; set; }
            public bool? startParticipantsVideo { get; set; }
            public string[] audioOptions { get; set; }
            public class Links
            {
                public string startUri { get; set; }
                public string joinUri { get; set; }
            }
            public class Schedule
            {
                public string startTime { get; set; }
                public int? durationInMinutes { get; set; }
                public TimeZone timeZone { get; set; }
                public class TimeZone
                {
                    public string id { get; set; }
                }
            }
        }
    }
}
