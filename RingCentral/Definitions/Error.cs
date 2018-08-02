namespace RingCentral
{
    public partial class Error
    {
        // Code that characterizes this error. Code uniqly identifies the source of the error.
        public string @errorCode { get; set; }
        // Message that describes the error. This message can be used in UI.
        public string @message { get; set; }
    }
}
