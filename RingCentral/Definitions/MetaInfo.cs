namespace RingCentral
{
    public partial class MetaInfo
    {
        // Specification links
        public string[] @schemas { get; set; }
        // User type
        public string @resourceType { get; set; }
        // Datetime of user creation in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        public string @created { get; set; }
        // Datetime of the last change of user information in ISO 8601 format,for example 2016-03-10T18:07:52.534Z
        public string @lastModified { get; set; }
        // User location
        public string @location { get; set; }
    }
}
