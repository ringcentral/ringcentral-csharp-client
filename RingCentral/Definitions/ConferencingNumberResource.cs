namespace RingCentral
{
    public partial class ConferencingNumberResource
    {
        //
        public string @uri { get; set; }
        //
        public string @phoneNumber { get; set; }
        //
        public CountryResource @country { get; set; }
        //
        public string @location { get; set; }
        //
        public bool? @hasGreeting { get; set; }
        //
        public bool? @default { get; set; }
    }
}
