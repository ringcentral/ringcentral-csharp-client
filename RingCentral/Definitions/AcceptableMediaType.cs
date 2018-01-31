namespace RingCentral
{
    public partial class AcceptableMediaType
    {
        //
        public string @type { get; set; }
        //
        public string @subtype { get; set; }
        //
        public long? @quality { get; set; }
        //
        public bool? @wildcardType { get; set; }
        //
        public bool? @wildcardSubtype { get; set; }
    }
}
