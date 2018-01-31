namespace RingCentral
{
    public partial class BillingStatementResource
    {
        //
        public FeeChargeResource[] @fees { get; set; }
        //
        public FeeChargeResource[] @charges { get; set; }
        //
        public double? @totalCharges { get; set; }
        //
        public double? @totalFees { get; set; }
        //
        public double? @subtotal { get; set; }
        //
        public string @currency { get; set; }
    }
}
