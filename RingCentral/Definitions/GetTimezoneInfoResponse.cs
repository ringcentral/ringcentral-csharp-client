namespace RingCentral
{
    public partial class GetTimezoneInfoResponse
    {
        // Internal identifier of a timezone
        public string @id { get; set; }
        // Canonical URI of the timezone
        public string @uri { get; set; }
        // Short name of the timezone
        public string @name { get; set; }
        // Description of the timezone
        public string @description { get; set; }
    }
}
