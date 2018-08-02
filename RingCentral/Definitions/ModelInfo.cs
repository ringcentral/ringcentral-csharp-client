namespace RingCentral
{
    public partial class ModelInfo
    {
        // Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
        public string @id { get; set; }
        // Device name
        public string @name { get; set; }
        // Addons description
        public AddonInfo[] @addons { get; set; }
        // Device feature or multiple features supported
        public string[] @features { get; set; }
    }
}
