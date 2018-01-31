namespace RingCentral
{
    public partial class GroupInfo
    {
        // Internal identifier of a group
        public string @id { get; set; }
        // Canonical URI of a group
        public string @uri { get; set; }
        // Amount of contacts in a group
        public long? @contactsCount { get; set; }
        // Name of a group
        public string @groupName { get; set; }
        // Notes for a group
        public string @notes { get; set; }
    }
}
