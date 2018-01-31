namespace RingCentral
{
    public partial class ExtensionCallerIdInfo
    {
        // Canonical URL of a caller ID resource
        public string @uri { get; set; }
        //
        public CallerIdByDevice[] @byDevice { get; set; }
        //
        public CallerIdByFeature[] @byFeature { get; set; }
    }
}
