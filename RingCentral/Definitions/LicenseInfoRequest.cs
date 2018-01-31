namespace RingCentral
{
    public partial class LicenseInfoRequest
    {
        // Type of a license
        public LicenseTypeInfoRequest @type { get; set; }
        // Quantity of licenses to be purchased
        public long? @quantity { get; set; }
    }
}
