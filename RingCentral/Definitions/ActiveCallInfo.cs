namespace RingCentral
{
    public partial class ActiveCallInfo
    {
        //
        public string @id { get; set; }
        //
        public string @direction { get; set; }
        // Phone number or extension number of a caller. For GCM transport type '_from' property should be used
        public string @from { get; set; }
        // Name of a caller
        public string @fromName { get; set; }
        // Phone number or extension number of a callee
        public string @to { get; set; }
        // Name of a callee
        public string @toName { get; set; }
        // Time when the call is actually started
        public string @startTime { get; set; }
        //
        public string @telephonyStatus { get; set; }
        //
        public DetailedCallInfo @sipData { get; set; }
        //
        public string @sessionId { get; set; }
        //
        public string @terminationType { get; set; }
    }
}
