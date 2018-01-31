namespace RingCentral
{
    public partial class BannerInfo
    {
        // Type of a banner
        public string @bannerType { get; set; }
        // Custom text description of a banner
        public string @description { get; set; }
        // HTML formatted message content
        public string @content { get; set; }
        // Datetime of message expiration in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @expirationDate { get; set; }
    }
}
