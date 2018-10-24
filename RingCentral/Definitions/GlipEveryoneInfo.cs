namespace RingCentral
{
    public partial class GlipEveryoneInfo
    {
        // Internal identifier of a chat
        public string @id { get; set; }
        // Type of a chat
        public string @type { get; set; }
        // Chat name.
        public string @name { get; set; }
        // Chat description.
        public string @description { get; set; }
        // Chat creation datetime in ISO 8601 format
        public string @creationTime { get; set; }
        // Chat last change datetime in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
