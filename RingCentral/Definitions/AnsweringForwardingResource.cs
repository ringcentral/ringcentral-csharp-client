namespace RingCentral
{
    public partial class AnsweringForwardingResource
    {
        //
        public bool? @notifyMySoftPhones { get; set; }
        //
        public bool? @notifyAdminSoftPhones { get; set; }
        //
        public long? @softPhonesRingCount { get; set; }
        //
        public string @ringingMode { get; set; }
        //
        public AnsweringForwardingRuleResource[] @rules { get; set; }
    }
}
