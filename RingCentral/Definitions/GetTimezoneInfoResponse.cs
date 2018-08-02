namespace RingCentral
{
    public partial class GetTimezoneInfoResponse
    {
        // Internal identifier of a timezone
        public string @id { get; set; }
        // Canonical URI of a timezone
        public string @uri { get; set; }
        // Short name of a timezone
        public string @name { get; set; }
        // Description of a timezone
        public string @description { get; set; }
    }
}
