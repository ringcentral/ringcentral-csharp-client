namespace RingCentral
{
    public partial class DictionaryLicenseInfo
    {
        // Canonical URI of a license
        public string @uri { get; set; }
        // Internal identifier of a license
        public long? @id { get; set; }
        // Name of a license
        public string @sku { get; set; }
        // Full name of a license
        public string @name { get; set; }
        // License type data
        public LicenseFeatureInfo @feature { get; set; }
        // State of a license. Webinars and Large Meetings are assignable
        public bool? @assignable { get; set; }
    }
}
