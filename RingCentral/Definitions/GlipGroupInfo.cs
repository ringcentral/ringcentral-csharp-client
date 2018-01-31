namespace RingCentral
{
    public partial class GlipGroupInfo
    {
        // Internal identifier of a group
        public string @id { get; set; }
        // Type of a group. 'PrivateChat' is a group of 2 members. 'Group' is a chat of 2 and more participants, the membership cannot be changed after group creation. 'Team' is a chat of 1 and more participants, the membership can be modified in future
        public string @type { get; set; }
        // For 'Team' group type only. Team access level
        public bool? @isPublic { get; set; }
        // For 'Team' group type only. Team name
        public string @name { get; set; }
        // For 'Team' group type only. Team description
        public string @description { get; set; }
        // Identifier(s) of group members
        public string[] @members { get; set; }
        // Group creation datetime in ISO 8601 format
        public string @creationTime { get; set; }
        // Group last change datetime in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
