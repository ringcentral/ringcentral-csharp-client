namespace RingCentral
{
    public partial class ForwardingInfo
    {
        // Specifies if the user's softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers
        public bool? @notifyMySoftPhones { get; set; }
        // Specifies if the administrator's softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is 'False'
        public bool? @notifyAdminSoftPhones { get; set; }
        // Number of rings before forwarding starts
        public long? @softPhonesRingCount { get; set; }
        // Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
        public string @ringingMode { get; set; }
        // Information on a call forwarding rule
        public RuleInfo[] @rules { get; set; }
    }
}
