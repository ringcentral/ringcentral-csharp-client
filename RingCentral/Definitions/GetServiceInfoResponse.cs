namespace RingCentral
{
    public partial class GetServiceInfoResponse
    {
        // Canonical URI of the account Service Info resource
        public string @uri { get; set; }
        // Account Service Plan name
        public string @servicePlanName { get; set; }
        // Service features information, see Service Feature List
        public ServiceFeatureInfo[] @serviceFeatures { get; set; }
        // Limits which are effective for the account
        public AccountLimits @limits { get; set; }
    }
}
