namespace RingCentral
{
    public partial class WeeklyScheduleInfo
    {
        // Time intervals for a particular day
        public TimeInterval[] @monday { get; set; }
        // Time intervals for a particular day
        public TimeInterval[] @tuesday { get; set; }
        // Time intervals for a particular day
        public TimeInterval[] @wednesday { get; set; }
        // Time intervals for a particular day
        public TimeInterval[] @thursday { get; set; }
        // Time intervals for a particular day
        public TimeInterval[] @friday { get; set; }
        // Time intervals for a particular day
        public TimeInterval[] @saturday { get; set; }
        // Time intervals for a particular day
        public TimeInterval[] @sunday { get; set; }
    }
}
