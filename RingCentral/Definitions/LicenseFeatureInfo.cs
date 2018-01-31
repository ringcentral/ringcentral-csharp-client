namespace RingCentral
{
    public partial class LicenseFeatureInfo
    {
        // Internal identifier of an feature
        public string @id { get; set; }
        // Full name of a feature
        public string @name { get; set; }
        // Maximum count of licenses of specific type per account
        public long? @limit { get; set; }
    }
}
