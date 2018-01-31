namespace RingCentral
{
    public partial class LocationInfo
    {
        // Canonical URI of a location
        public string @uri { get; set; }
        // Area code of the location
        public string @areaCode { get; set; }
        // Official name of the city, belonging to the certain state
        public string @city { get; set; }
        // Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        public string @npa { get; set; }
        // Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        public string @nxx { get; set; }
        // ID and URI of the state this location belongs to, see State Info
        public string @state { get; set; }
    }
}
