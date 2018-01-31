namespace RingCentral
{
    public partial class InvoiceSettingsResource
    {
        //
        public long? @maxAmountPerFirstMonth { get; set; }
        //
        public long? @maxAmountPerMonth { get; set; }
        //
        public long? @paymentTerm { get; set; }
        //
        public long? @period { get; set; }
        //
        public Address @address { get; set; }
    }
}
