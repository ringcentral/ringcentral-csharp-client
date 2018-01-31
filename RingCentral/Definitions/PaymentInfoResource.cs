namespace RingCentral
{
    public partial class PaymentInfoResource
    {
        //
        public string @uri { get; set; }
        //
        public string @paymentType { get; set; }
        //
        public PaymentInfoCardResource @card { get; set; }
        //
        public InvoiceSettingsResource @invoiceSettings { get; set; }
    }
}
