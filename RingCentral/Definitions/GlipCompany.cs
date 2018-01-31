namespace RingCentral
{
    public partial class GlipCompany
    {
        // Internal identifier of an RC account/Glip company, or tilde (~) to indicate a company the current user belongs to
        public string @id { get; set; }
        // Name of a company
        public string @name { get; set; }
        // Domain name of a company
        public string @domain { get; set; }
        // Datetime of creation in ISO 8601 format
        public string @creationTime { get; set; }
        // Datetime of last modification in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
