namespace RingCentral
{
    public partial class CallParty
    {
        // Internal identifier of a party
        public string @id { get; set; }
        // Status data of a call session
        public CallStatusInfo @status { get; set; }
        // Specifies if a call participant is muted or not
        public bool? @muted { get; set; }
        // True if party is not connected to a session voice conference. False - otherwise
        public bool? @standAlone { get; set; }
        // Call park information
        public ParkInfo @park { get; set; }
        // Data on a calling party
        public PartyInfo @from { get; set; }
        // Data on a called party
        public PartyInfo @to { get; set; }
        // Data on a call owner
        public OwnerInfo @owner { get; set; }
        // Direction of a call
        public string @direction { get; set; }
        // A party's role in the conference scenarios. For calls of 'Conference' type only
        public string @conferenceRole { get; set; }
        // A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringout' type only
        public string @ringOutRole { get; set; }
        // A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringme' type only
        public string @ringMeRole { get; set; }
        // Active recordings list
        public RecordingInfo[] @recordings { get; set; }
    }
}
