namespace RingCentral
{
    public partial class FaxCallerInfo
    {
        // Recipient information. Phone number property is mandatory. Optional for resend fax request
        public string @phoneNumber { get; set; }
    }
}
