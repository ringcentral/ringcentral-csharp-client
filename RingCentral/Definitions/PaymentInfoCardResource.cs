namespace RingCentral
{
    public partial class PaymentInfoCardResource
    {
        //
        public string @cardType { get; set; }
        //
        public string @number { get; set; }
        //
        public string @securityCode { get; set; }
        //
        public string @expiry { get; set; }
        //
        public string @token { get; set; }
        //
        public PaymentInfoCardHolderResource @holder { get; set; }
    }
}
