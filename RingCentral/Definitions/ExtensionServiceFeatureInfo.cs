namespace RingCentral
{
    public partial class ExtensionServiceFeatureInfo
    {
        // Feature status; shows feature availability for an extension
        public bool? @enabled { get; set; }
        // Feature name, see all available values in Service Feature List
        public string @featureName { get; set; }
        // Reason of limitation for a particular service feature. Returned only if the enabled parameter value is 'False', see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response
        public string @reason { get; set; }
    }
}
