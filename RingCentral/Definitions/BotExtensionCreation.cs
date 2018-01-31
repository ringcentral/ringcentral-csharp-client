namespace RingCentral
{
    public partial class BotExtensionCreation
    {
        // Link to a bot extension resource
        public string @uri { get; set; }
        // Internal identifier of a bot extension
        public string @id { get; set; }
        // Bot extension number
        public string @extensionNumber { get; set; }
        // Bot name (equals to extension first name)
        public string @name { get; set; }
        // Identifier key of a bot application
        public string @applicationKey { get; set; }
        // User extension identifier
        public string @creatorId { get; set; }
    }
}
