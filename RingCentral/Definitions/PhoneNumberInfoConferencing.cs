namespace RingCentral
{
    public partial class PhoneNumberInfoConferencing
    {
        // Information on a home country of a conference phone number
        public GetCountryInfoConferencing @country { get; set; }
        // 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        public bool? @default { get; set; }
        // 'True' if the greeting message is played on this number
        public bool? @hasGreeting { get; set; }
        // Location (city, region, state) of a conference phone number
        public string @location { get; set; }
        // Dial-in phone number to connect to a conference
        public string @phoneNumber { get; set; }
    }
}
