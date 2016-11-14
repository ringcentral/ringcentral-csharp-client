namespace RingCentral
{
    public partial class ServiceFeatureInfo
    {
        // Feature name, see all available values in Service Feature List
        public string @featureName { get; set; }
        // Feature status, shows feature availability for the extension
        public bool? @enabled { get; set; }
    }
}
