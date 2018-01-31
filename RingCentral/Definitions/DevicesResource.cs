namespace RingCentral
{
    public partial class DevicesResource
    {
        //
        public string @uri { get; set; }
        //
        public DeviceResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
