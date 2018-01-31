namespace RingCentral
{
    public partial class PresencePermissions
    {
        //
        public string @targetExtensionId { get; set; }
        //
        public string @subscriberExtensionId { get; set; }
        //
        public bool? @canReadPresenceStatus { get; set; }
        //
        public bool? @canReadPresenceSettings { get; set; }
        //
        public bool? @canPickup { get; set; }
    }
}
