namespace RingCentral
{
    public partial class FederationInfo
    {
        // Internal identifier of a federation
        public string @id { get; set; }
        // Name of a federation
        public string @displayName { get; set; }
        // Datetime of federation creation, in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // Datetime of the last change of federation composition, in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        public string @lastModifiedTime { get; set; }
        // List of countries which can be selected for a dialing plan
        public FederationAccountInfo[] @accounts { get; set; }
    }
}
