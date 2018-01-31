namespace RingCentral
{
    public partial class ContactInfoUpdateRequest
    {
        // For User extension type only. Extension user first name,
        public string @firstName { get; set; }
        // For User extension type only. Extension user last name,
        public string @lastName { get; set; }
        // Extension user company name
        public string @company { get; set; }
        // Email of extension user
        public string @email { get; set; }
        // Extension user contact phone number in E.164 format
        public string @businessPhone { get; set; }
        //
        public ContactAddressInfo @businessAddress { get; set; }
        //  If 'True' then contact email is enabled as login name for this user. Please note that email should be unique in this case. The default value is 'False'
        public bool? @emailAsLoginName { get; set; }
        //
        public PronouncedNameInfo @pronouncedName { get; set; }
        // Extension user department, if any
        public string @department { get; set; }
    }
}
