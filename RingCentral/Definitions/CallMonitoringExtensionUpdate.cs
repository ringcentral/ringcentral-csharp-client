namespace RingCentral
{
    public partial class CallMonitoringExtensionUpdate
    {
        //  Only the following extension types are allowed: User, DigitalUser, VirtualUser, FaxUser, Limited
        public string @id { get; set; }
        //
        public string[] @permissions { get; set; }
    }
}
