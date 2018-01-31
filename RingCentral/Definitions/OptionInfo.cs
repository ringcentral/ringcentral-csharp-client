namespace RingCentral
{
    public partial class OptionInfo
    {
        // Specifies if the feature is allowed ('True') or disallowed ('False') for the special number
        public bool? @enabled { get; set; }
        // The reason explaining why the option is disallowed. Returned if the value of enabled is 'False'
        public OptionInfoReason @reason { get; set; }
    }
}
