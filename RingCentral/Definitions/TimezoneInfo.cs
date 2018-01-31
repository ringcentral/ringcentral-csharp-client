namespace RingCentral
{
    public partial class TimezoneInfo
    {
        // Internal identifier of a timezone
        public string @id { get; set; }
        // Canonical URI of a timezone
        public string @uri { get; set; }
        // Short name of a timezone
        public string @name { get; set; }
        // Meaningful description of the timezone
        public string @description { get; set; }
    }
}
