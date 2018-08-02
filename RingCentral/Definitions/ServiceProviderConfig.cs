namespace RingCentral
{
    public partial class ServiceProviderConfig
    {
        //
        public AuthenticationSchemes @authenticationSchemes { get; set; }
        //
        public BulkSupported @bulk { get; set; }
        //
        public Supported @changePassword { get; set; }
        //
        public Supported @etag { get; set; }
        //
        public FilterSupported @filter { get; set; }
        //
        public Supported @patch { get; set; }
        //
        public string[] @schemas { get; set; }
        //
        public Supported @sort { get; set; }
        //
        public Supported @xmlDataFormat { get; set; }
    }
}
