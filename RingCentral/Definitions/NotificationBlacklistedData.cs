namespace RingCentral
{
    public partial class NotificationBlacklistedData
    {
        // Time of adding subscrition to a black list in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        public string @blacklistedAt { get; set; }
        // Reason of adding subscrition to a black list
        public string @reason { get; set; }
    }
}
