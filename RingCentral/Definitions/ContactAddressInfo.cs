namespace RingCentral
{
    public partial class ContactAddressInfo
    {
        // Country name of extension user company. Not returned for Address Book
        public string @country { get; set; }
        // State/province name of extension user company
        public string @state { get; set; }
        // City name of extension user company
        public string @city { get; set; }
        // Street address of extension user company
        public string @street { get; set; }
        // Zip code of extension user company
        public string @zip { get; set; }
    }
}
