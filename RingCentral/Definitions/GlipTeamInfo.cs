namespace RingCentral
{
    public partial class GlipTeamInfo
    {
        // Internal identifier of a team
        public string @id { get; set; }
        // Type of a chat
        public string @type { get; set; }
        // Team access level.
        public bool? @public { get; set; }
        // Team name.
        public string @name { get; set; }
        // Team description.
        public string @description { get; set; }
        // Team status.
        public string @status { get; set; }
        // Team creation datetime in ISO 8601 format
        public string @creationTime { get; set; }
        // Team last change datetime in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
