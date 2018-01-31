namespace RingCentral
{
    public partial class GetConferencingInfoResponse
    {
        // Canonical URI of a conferencing
        public string @uri { get; set; }
        // Determines if host user allows conference participants to join before the host
        public bool? @allowJoinBeforeHost { get; set; }
        // Access code for a host user
        public string @hostCode { get; set; }
        // Internal parameter specifying conferencing engine
        public string @mode { get; set; }
        // Access code for any participant
        public string @participantCode { get; set; }
        // Primary conference phone number for user's home country returned in E.164 (11-digits) format
        public string @phoneNumber { get; set; }
        // Short URL leading to the service web page Tap to Join for audio conference bridge
        public string @tapToJoinUri { get; set; }
        // List of multiple dial-in phone numbers to connect to audio conference service, relevant for user's brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
        public PhoneNumberInfoConferencing[] @phoneNumbers { get; set; }
    }
}
