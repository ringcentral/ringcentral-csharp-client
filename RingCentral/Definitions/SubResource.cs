namespace RingCentral
{
    public partial class SubResource
    {
        //
        public string @uri { get; set; }
        //
        public string @resourceDescription { get; set; }
        //
        public long? @parentId { get; set; }
        //
        public long? @subId { get; set; }
        //
        public ApiVersionResource @subVer { get; set; }
    }
}
