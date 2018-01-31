namespace RingCentral
{
    public partial class ExtensionStatusInfo
    {
        // A free-form user comment, describing the status change reason
        public string @comment { get; set; }
        // Type of suspension
        public string @reason { get; set; }
    }
}
