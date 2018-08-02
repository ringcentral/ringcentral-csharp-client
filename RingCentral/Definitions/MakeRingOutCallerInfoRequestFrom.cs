namespace RingCentral
{
    public partial class MakeRingOutCallerInfoRequestFrom
    {
        // Phone number in E.164 format
        public string @phoneNumber { get; set; }
        // Internal identifier of a forwarding number; returned in response as an 'id' field value. Can be specified instead of the phoneNumber attribute
        public string @forwardingNumberId { get; set; }
    }
}
