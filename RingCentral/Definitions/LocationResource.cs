namespace RingCentral
{
    public partial class LocationResource
    {
        //
        public string @uri { get; set; }
        //
        public string @city { get; set; }
        //
        public string @areaCode { get; set; }
        //
        public string @npa { get; set; }
        //
        public string @nxx { get; set; }
        //
        public VersionedResource @state { get; set; }
    }
}
