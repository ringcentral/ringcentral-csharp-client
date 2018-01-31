namespace RingCentral
{
    public partial class PostGlipFile
    {
        // Internal identifier of a file
        public string @id { get; set; }
        // Link to binary content
        public string @contentUri { get; set; }
        // Name of a file
        public string @name { get; set; }
    }
}
