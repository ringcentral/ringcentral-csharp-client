namespace RingCentral
{
    public partial class PartyUpdateInfo
    {
        // True if the party is muted. False - otherwise
        public bool? @muted { get; set; }
        // True if party is not connected to a session voice conference. False - otherwise
        public bool? @standAlone { get; set; }
    }
}
