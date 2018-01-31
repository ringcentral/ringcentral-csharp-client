namespace RingCentral
{
    public partial class MakeRingOutCallerInfoRequestFrom
    {
        // Phone number in E.164 format
        public string @phoneNumber { get; set; }
        // Internal identifier of a forwarding number; returned in response in the id field. Can be specified instead of the phoneNumber attribute
        public string @forwardingNumberId { get; set; }
    }
}
