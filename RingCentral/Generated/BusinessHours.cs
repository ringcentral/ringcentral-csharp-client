
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BusinessHours : Model
    {
        internal BusinessHours(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "business-hours";
            }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public class GetResponse
        {
            public string uri { get; set; }
            public Schedule schedule { get; set; }
            public class Schedule
            {
                public WeeklyRanges weeklyRanges { get; set; }
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
            }
        }
    }
}
