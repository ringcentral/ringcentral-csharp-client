namespace RingCentral
{
    public partial class ConflictsInfo
    {
        // Internal identifier of a conflicting extension assigned to another account of the current federation
        public string @id { get; set; }
        // Extension user first name
        public string @firstName { get; set; }
        // Extension user last name
        public string @lastName { get; set; }
        // Account data of an extension
        public FederationConflictsAccountInfo @account { get; set; }
    }
}
