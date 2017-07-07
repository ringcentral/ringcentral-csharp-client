namespace RingCentral
{
    public partial class BillingInfo
    {
        // Cost per minute used included in your RingCentral Plan
        public double? @costIncluded { get; set; }
        // Cost per minute used not included in your RingCentral Plan. for example International Calls
        public double? @costPurchased { get; set; }
    }
}
