namespace RingCentral
{
    public partial class ProfileImageResource
    {
        //
        public string @uri { get; set; }
        //
        public string @etag { get; set; }
        //
        public string @contentType { get; set; }
        //
        public string @lastModified { get; set; }
        //
        public ScaledProfileImageResource[] @scales { get; set; }
    }
}
