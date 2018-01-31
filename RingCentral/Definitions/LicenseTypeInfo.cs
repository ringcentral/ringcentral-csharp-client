namespace RingCentral
{
    public partial class LicenseTypeInfo
    {
        // Internal identifier of a type
        public string @id { get; set; }
        // Canonical URI of a license type resource
        public string @uri { get; set; }
        // Short name of a license type
        public string @sku { get; set; }
        // Full name of a license type
        public string @name { get; set; }
        // State of a license. Webinars and Large Meetings are assignable
        public string @assignable { get; set; }
        // License feature info
        public LicenseFeatureInfo @feature { get; set; }
    }
}
