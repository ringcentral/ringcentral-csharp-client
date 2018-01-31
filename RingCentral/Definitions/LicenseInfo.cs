namespace RingCentral
{
    public partial class LicenseInfo
    {
        // Canonical URI of a license
        public string @uri { get; set; }
        // Internal identifier of a license
        public string @id { get; set; }
        // License type data
        public LicenseFeatureInfo @type { get; set; }
        // Datetime when license was purchased in ISO 8601 format including timezone, for example 2017-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // Information on extension to which a license can be assigned
        public LicenseExtensionInfo @extension { get; set; }
    }
}
