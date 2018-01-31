namespace RingCentral
{
    public partial class Conferencing_Request_PhoneNumber
    {
        // Dial-in phone number to connect to a conference
        public string @phoneNumber { get; set; }
        // 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        public bool? @default { get; set; }
    }
}
