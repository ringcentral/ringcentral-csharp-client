namespace RingCentral
{
    public partial class ParsedNumberResource
    {
        //
        public string @uri { get; set; }
        //
        public string @originalString { get; set; }
        //
        public CountryResource @country { get; set; }
        //
        public string @areaCode { get; set; }
        //
        public string @subscriberNumber { get; set; }
        //
        public string @formattedNational { get; set; }
        //
        public string @formattedInternational { get; set; }
        //
        public string @dialable { get; set; }
        //
        public string @e164 { get; set; }
        //
        public bool? @special { get; set; }
        //
        public string @normalized { get; set; }
        //
        public bool? @tollFree { get; set; }
        //
        public string @subAddress { get; set; }
        //
        public string @dtmfPostfix { get; set; }
    }
}
