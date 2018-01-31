namespace RingCentral
{
    public partial class MeetingServiceInfoResource
    {
        //
        public string @uri { get; set; }
        //
        public string @supportUri { get; set; }
        //
        public string @intlDialInNumbersUri { get; set; }
        //
        public MeetingExternalUserInfoResource @externalUserInfo { get; set; }
        //
        public DialInNumberResource[] @dialInNumbers { get; set; }
    }
}
