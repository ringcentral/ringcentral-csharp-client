namespace RingCentral
{
    public partial class BillingPlanInfo
    {
        // Internal identifier of a billing plan
        public string @id { get; set; }
        // Billing plan name
        public string @name { get; set; }
        // Duration period
        public string @durationUnit { get; set; }
        // Number of duration units
        public string @duration { get; set; }
        // Billing plan type
        public string @type { get; set; }
    }
}
