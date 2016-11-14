namespace RingCentral
{
    public partial class GreetingInfo
    {
        // Type of a greeting, specifying the case when the greeting is played. See also Greeting Types
        public string @type { get; set; }
        // Predefined greeting information
        public PresetInfo @preset { get; set; }
    }
}
