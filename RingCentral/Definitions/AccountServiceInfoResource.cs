namespace RingCentral
{
    public partial class AccountServiceInfoResource
    {
        //
        public string @uri { get; set; }
        //
        public string @servicePlanName { get; set; }
        //
        public Brand @brand { get; set; }
        //
        public ServicePlan @servicePlan { get; set; }
        //
        public ServicePlan @targetServicePlan { get; set; }
        //
        public BillingPlanResource @billingPlan { get; set; }
        //
        public ServiceFeatureValue[] @serviceFeatures { get; set; }
        //
        public AccountLimitsResource @limits { get; set; }
    }
}
