namespace RingCentral
{
    public partial class DialInNumberResource
    {
        //
        public string @phoneNumber { get; set; }
        //
        public string @formattedNumber { get; set; }
        //
        public string @location { get; set; }
        //
        public CountryResource @country { get; set; }
    }
}
