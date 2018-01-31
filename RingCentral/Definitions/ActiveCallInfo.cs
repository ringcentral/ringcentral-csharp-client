namespace RingCentral
{
    public partial class ActiveCallInfo
    {
        //
        public string @id { get; set; }
        //
        public string @direction { get; set; }
        //
        public string @from { get; set; }
        //
        public string @to { get; set; }
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
