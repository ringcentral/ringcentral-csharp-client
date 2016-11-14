namespace RingCentral
{
    public partial class ProfileImageInfo
    {
        // Link to a profile image. If an image is not uploaded for an extension, only uri is returned
        public string @uri { get; set; }
        // Identifier of an image
        public string @etag { get; set; }
        // The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        public string @lastModified { get; set; }
        // The type of an image
        public string @contentType { get; set; }
        // List of URIs to profile images in different dimensions
        public ImageUri[] @scales { get; set; }
    }
}
