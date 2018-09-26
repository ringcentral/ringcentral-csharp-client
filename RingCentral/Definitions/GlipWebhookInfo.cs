namespace RingCentral
{
    public partial class GlipWebhookInfo
    {
        // Internal identifier of a webhook
        public string @id { get; set; }
        // Internal identifier of the user who created a webhook
        public string @creatorId { get; set; }
        // Internal identifiers of groups where a webhook has been created
        public string[] @groupsId { get; set; }
        // Webhook creation time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string @creationTime { get; set; }
        // Webhook last update time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string @lastModifiedTime { get; set; }
        // Public link to send a webhook payload
        public string @uri { get; set; }
        // Current status of a webhook
        public string @status { get; set; }
    }
}
