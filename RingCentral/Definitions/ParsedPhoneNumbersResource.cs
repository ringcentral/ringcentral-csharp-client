namespace RingCentral
{
    public partial class ParsedPhoneNumbersResource
    {
        //
        public string @uri { get; set; }
        //
        public HomeCountryResource @homeCountry { get; set; }
        //
        public ParsedNumberResource[] @phoneNumbers { get; set; }
    }
}
