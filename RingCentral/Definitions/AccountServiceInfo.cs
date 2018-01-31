namespace RingCentral
{
    public partial class AccountServiceInfo
    {
        // Canonical URI of the account Service Info resource
        public string @uri { get; set; }
        // Account Service Plan name
        public string @servicePlanName { get; set; }
        // Information on account brand
        public BrandInfo @brand { get; set; }
        // Information on account service plan
        public ServicePlanInfo @servicePlan { get; set; }
        // Information on account billing plan
        public BillingPlanInfo @billingPlan { get; set; }
        // Service features information, see Service Feature List
        public ServiceFeatureInfo[] @serviceFeatures { get; set; }
        // Limits which are effective for an account
        public AccountLimits @limits { get; set; }
    }
}
