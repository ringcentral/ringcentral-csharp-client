namespace RingCentral
{
    public partial class GlipCreateGroup
    {
        // Type of a group to be created. 'PrivateChat' is a group of 2 members. 'Team' is a chat of 1 and more participants, the membership can be modified in future
        public string @type { get; set; }
        // For 'Team' group type only. Team access level
        public bool? @isPublic { get; set; }
        // For 'Team' group type only. Team name
        public string @name { get; set; }
        // For 'Team' group type only. Team description
        public string @description { get; set; }
        // Identifier(s) of group members. For 'PrivateChat' group type 2 members only are supported
        public string[] @members { get; set; }
    }
}
