namespace RingCentral
{
    public partial class RingOutResource
    {
        //
        public RingOutFromInfo @from { get; set; }
        //
        public RingOutPhoneNumberInfo @to { get; set; }
        //
        public RingOutPhoneNumberInfo @callerId { get; set; }
        //
        public bool? @playPrompt { get; set; }
        //
        public RingOutCountry @country { get; set; }
    }
}
