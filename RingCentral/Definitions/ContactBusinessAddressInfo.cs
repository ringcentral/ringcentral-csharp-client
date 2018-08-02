namespace RingCentral
{
    public partial class ContactBusinessAddressInfo
    {
        // Country name of an extension user company
        public string @country { get; set; }
        // State/province name of an extension user company. Mandatory for the USA, UK and Canada
        public string @state { get; set; }
        // City name of an extension user company
        public string @city { get; set; }
        // Street address of an extension user company
        public string @street { get; set; }
        // Zip code of an extension user company
        public string @zip { get; set; }
    }
}
