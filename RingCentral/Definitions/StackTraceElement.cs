namespace RingCentral
{
    public partial class StackTraceElement
    {
        //
        public string @methodName { get; set; }
        //
        public string @fileName { get; set; }
        //
        public long? @lineNumber { get; set; }
        //
        public string @className { get; set; }
        //
        public bool? @nativeMethod { get; set; }
    }
}
