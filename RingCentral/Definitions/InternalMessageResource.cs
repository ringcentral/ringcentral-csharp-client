namespace RingCentral
{
    public partial class InternalMessageResource
    {
        //
        public CallerInfo[] @to { get; set; }
        //
        public CallerInfo @from { get; set; }
        //
        public string @text { get; set; }
        //
        public long? @replyOn { get; set; }
    }
}
