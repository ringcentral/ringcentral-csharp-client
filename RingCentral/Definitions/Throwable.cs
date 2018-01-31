namespace RingCentral
{
    public partial class Throwable
    {
        //
        public Throwable @cause { get; set; }
        //
        public StackTraceElement[] @stackTrace { get; set; }
        //
        public string @localizedMessage { get; set; }
        //
        public string @message { get; set; }
        //
        public Throwable[] @suppressed { get; set; }
    }
}
