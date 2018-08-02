namespace RingCentral
{
    public partial class MakeRingOutRequest
    {
        // Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of user's configured forwarding numbers or arbitrary number
        public MakeRingOutCallerInfoRequestFrom @from { get; set; }
        // Phone number of the called party. This number corresponds to the 2nd leg of a RingOut call
        public MakeRingOutCallerInfoRequestTo @to { get; set; }
        // The number which will be displayed to the called party
        public MakeRingOutCallerInfoRequestTo @callerId { get; set; }
        // The audio prompt that the calling party hears when the call is connected
        public bool? @playPrompt { get; set; }
        // Optional. Dialing plan country data. If not specified, then extension home country is applied by default
        public MakeRingOutCoutryInfo @country { get; set; }
    }
}
