namespace RingCentral
{
    public partial class AccountStatusInfo
    {
        // A free-form user comment, describing the status change reason
        public string @comment { get; set; }
        // Type of suspension
        public string @reason { get; set; }
        // Date until which the account will get deleted. The default value is 30 days since current date
        public string @till { get; set; }
    }
}
