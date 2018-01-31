namespace RingCentral
{
    public partial class CompanyAnsweringRuleWeeklyScheduleInfoRequest
    {
        // Time interval for a particular day
        public CompanyAnsweringRuleTimeIntervalRequest[] @monday { get; set; }
        // Time interval for a particular day
        public CompanyAnsweringRuleTimeIntervalRequest[] @tuesday { get; set; }
        // Time interval for a particular day
        public CompanyAnsweringRuleTimeIntervalRequest[] @wednesday { get; set; }
        // Time interval for a particular day
        public CompanyAnsweringRuleTimeIntervalRequest[] @thursday { get; set; }
        // Time interval for a particular day
        public CompanyAnsweringRuleTimeIntervalRequest[] @friday { get; set; }
        // Time interval for a particular day
        public CompanyAnsweringRuleTimeIntervalRequest[] @saturday { get; set; }
        // Time interval for a particular day
        public CompanyAnsweringRuleTimeIntervalRequest[] @sunday { get; set; }
    }
}
