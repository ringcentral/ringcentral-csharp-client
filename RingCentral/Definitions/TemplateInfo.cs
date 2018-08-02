namespace RingCentral
{
    public partial class TemplateInfo
    {
        // Link to a template
        public string @uri { get; set; }
        // Internal identifier of a template
        public string @id { get; set; }
        //
        public string @type { get; set; }
        // Name of a template
        public string @name { get; set; }
        // Time of a template creation
        public string @creationTime { get; set; }
        // Time of the last template modification
        public string @lastModifiedTime { get; set; }
    }
}
