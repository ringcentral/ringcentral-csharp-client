namespace RingCentral
{
    public partial class ClientProvisioningHintInfo
    {
        // Seconds until expiration date. Returned only if applicable
        public long? @expiresIn { get; set; }
        // 'False', if the value of expiresIn is greater than 0 (zero), otherwise - 'True'
        public bool? @actionRequired { get; set; }
    }
}
