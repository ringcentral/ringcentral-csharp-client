namespace RingCentral
{
    public partial class FaxResendInfo
    {
        //
        public long? @originalMessageId { get; set; }
        //
        public string @sendTime { get; set; }
        //
        public CallerInfo[] @to { get; set; }
    }
}
