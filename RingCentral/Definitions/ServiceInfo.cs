namespace RingCentral
{
    public partial class ServiceInfo
    {
        // Canonical URI of a service info resource
        public string @uri { get; set; }
        // Information on account billing plan
        public BillingPlanInfo @billingPlan { get; set; }
        // Information on account brand
        public BrandInfo @brand { get; set; }
        // Information on account service plan
        public ServicePlanInfo @servicePlan { get; set; }
        // Information on account target service plan
        public TargetServicePlanInfo @targetServicePlan { get; set; }
    }
}
