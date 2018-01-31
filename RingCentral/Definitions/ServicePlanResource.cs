namespace RingCentral
{
    public partial class ServicePlanResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @name { get; set; }
        //
        public string @edition { get; set; }
        //
        public BrandResource @brand { get; set; }
        //
        public string @type { get; set; }
        //
        public ServiceFeatureValue[] @serviceFeatures { get; set; }
        //
        public AccountLimitsResource @limits { get; set; }
    }
}
