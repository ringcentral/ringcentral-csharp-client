namespace RingCentral
{
    public partial class ModelInfo
    {
        // Device model identifier. Mandatory when ordering a HardPhone if boxBillingId is not used for ordering
        public string @id { get; set; }
        // Device name
        public string @name { get; set; }
        // Addons description
        public AddonInfo[] @addons { get; set; }
    }
}
