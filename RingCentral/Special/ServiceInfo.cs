namespace RingCentral
{
    public partial class ServiceInfo
    {
        public partial class GetResponse
        {
            // Account Service Plan name
            public string servicePlanName { get; set; }
            // Service features information, see Service Feature List
            public ServiceFeatureInfo[] serviceFeatures { get; set; }
            // Limits which are effective for the account
            public AccountLimits limits { get; set; }
        }
    }
}
