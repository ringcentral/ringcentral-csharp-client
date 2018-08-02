namespace RingCentral
{
    public partial class GlipWebhookInfo
    {
        // ID of the webhook
        public string @id { get; set; }
        // ID of user whe created webhook
        public string @creatorId { get; set; }
        // IDs of groups where webhook has been created
        public string[] @groupsId { get; set; }
        // Webhook creation time in ISO 8601 format
        public string @creationTime { get; set; }
        // Webhook last update time in ISO 8601 format
        public string @lastModifiedTime { get; set; }
        // Public url to send webhook's payload
        public string @uri { get; set; }
        // Current status of the webhook, one of 'Active', 'Suspended' or 'Deleted'
        public string @status { get; set; }
    }
}
