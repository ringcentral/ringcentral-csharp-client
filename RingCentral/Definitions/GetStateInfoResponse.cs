namespace RingCentral
{
    public partial class GetStateInfoResponse
    {
        // Internal identifier of a state
        public string @id { get; set; }
        // Canonical URI of a state
        public string @uri { get; set; }
        // Information on a country the state belongs to
        public GetCountryInfoState @country { get; set; }
        // Short code for a state (2-letter usually)
        public string @isoCode { get; set; }
        // Official name of a state
        public string @name { get; set; }
    }
}
