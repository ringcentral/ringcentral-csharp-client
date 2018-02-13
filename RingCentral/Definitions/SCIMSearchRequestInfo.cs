namespace RingCentral
{
    public partial class SCIMSearchRequestInfo
    {
        // page size
        public long? @count { get; set; }
        // only support 'userName' or 'email' filter expressions for now
        public string @filter { get; set; }
        //
        public string[] @schemas { get; set; }
        // start index (1-based)
        public long? @startIndex { get; set; }
    }
}
