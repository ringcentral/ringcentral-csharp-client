
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AnsweringRule : Model
    {
        internal AnsweringRule(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "answering-rule";
            }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string uri { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public bool? enabled { get; set; }
            public Schedule schedule { get; set; }
            public CalledNumber[] calledNumbers { get; set; }
            public Caller[] callers { get; set; }
            public string callHandlingAction { get; set; }
            public Forwarding forwarding { get; set; }
            public UnconditionalForwarding unconditionalForwarding { get; set; }
            public Voicemail voicemail { get; set; }
            public class Schedule
            {
                public WeeklyRanges weeklyRanges { get; set; }
                public Ranges ranges { get; set; }
                public string @ref { get; set; }
                public class WeeklyRanges
                {
                    public Monday[] monday { get; set; }
                    public Tuesday[] tuesday { get; set; }
                    public Wednesday[] wednesday { get; set; }
                    public Thursday[] thursday { get; set; }
                    public Friday[] friday { get; set; }
                    public Saturday[] saturday { get; set; }
                    public Sunday[] sunday { get; set; }
                    public class Monday
                    {
                        public string from { get; set; }
                        public string to { get; set; }
                    }
                    public class Tuesday
                    {
                        public string from { get; set; }
                        public string to { get; set; }
                    }
                    public class Wednesday
                    {
                        public string from { get; set; }
                        public string to { get; set; }
                    }
                    public class Thursday
                    {
                        public string from { get; set; }
                        public string to { get; set; }
                    }
                    public class Friday
                    {
                        public string from { get; set; }
                        public string to { get; set; }
                    }
                    public class Saturday
                    {
                        public string from { get; set; }
                        public string to { get; set; }
                    }
                    public class Sunday
                    {
                        public string from { get; set; }
                        public string to { get; set; }
                    }
                }
                public class Ranges
                {
                    public string from { get; set; }
                    public string to { get; set; }
                }
            }
            public class CalledNumber
            {
                public string phoneNumber { get; set; }
            }
            public class Caller
            {
                public string callerId { get; set; }
                public string name { get; set; }
            }
            public class Forwarding
            {
                public bool? notifyMySoftPhones { get; set; }
                public bool? notifyAdminSoftPhones { get; set; }
                public int? softPhonesRingCount { get; set; }
                public string ringingMode { get; set; }
                public Rule[] rules { get; set; }
                public class Rule
                {
                    public int? index { get; set; }
                    public int? ringCount { get; set; }
                    public ForwardingNumber[] forwardingNumbers { get; set; }
                    public class ForwardingNumber
                    {
                        public string uri { get; set; }
                        public string id { get; set; }
                        public string phoneNumber { get; set; }
                        public string label { get; set; }
                    }
                }
            }
            public class UnconditionalForwarding
            {
                public string phoneNumber { get; set; }
            }
            public class Voicemail
            {
                public bool? enabled { get; set; }
                public Recipient recipient { get; set; }
                public class Recipient
                {
                    public string uri { get; set; }
                    public string id { get; set; }
                }
            }
        }
    }
}
