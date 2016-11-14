namespace RingCentral
{
    public partial class AddonInfo
    {
        // Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
        public string @id { get; set; }
        // Number of addons. For HardPhones of certain types, which are compatible with such addon identifier
        public long? @count { get; set; }
    }
}
