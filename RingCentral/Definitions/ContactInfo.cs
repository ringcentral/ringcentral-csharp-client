namespace RingCentral
{
    public partial class ContactInfo
    {
        // For User extension type only. Extension user first name
        public string @firstName { get; set; }
        // For User extension type only. Extension user last name
        public string @lastName { get; set; }
        // Extension user company name
        public string @company { get; set; }
        // Email of extension user
        public string @email { get; set; }
        // Extension user contact phone number
        public string @businessPhone { get; set; }
        // Business address of extension user company
        public ContactAddressInfo @businessAddress { get; set; }
    }
}
