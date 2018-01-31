namespace RingCentral
{
    public partial class FederationAccountInfo
    {
        // Internal identifier of an account
        public string @id { get; set; }
        // Company name of an account
        public string @companyName { get; set; }
        // Federation name of an account
        public string @federatedName { get; set; }
        // Datetime when this account was linked to a federation, in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        public string @linkCreationTime { get; set; }
        // Main company number information
        public FederationMainNumberInfo @mainNumber { get; set; }
        // Count of federation extension numbers conflicting with extension numbers of the requested account. For extension numbers of the requested account the value of this parameter is '0'
        public long? @conflictCount { get; set; }
    }
}
