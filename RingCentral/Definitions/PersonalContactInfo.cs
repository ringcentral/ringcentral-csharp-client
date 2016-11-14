namespace RingCentral
{
    public partial class PersonalContactInfo
    {
        // Standard resource properties ID
        public long? @id { get; set; }
        // Canonical URI
        public string @url { get; set; }
        // This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
        public string @availability { get; set; }
        // First name of a personal contact
        public string @firstName { get; set; }
        // Last name of a personal contact
        public string @lastName { get; set; }
        // Middle name of a personal contact
        public string @middleName { get; set; }
        // Nick name of a personal contact
        public string @nickName { get; set; }
        // Company name of a personal contact
        public string @company { get; set; }
        // Job title of a personal contact
        public string @jobTitle { get; set; }
        // Home phone of a personal contact
        public string @homePhone { get; set; }
        // The 2-d home phone of a personal contact
        public string @homePhone2 { get; set; }
        // Business phone of a personal contact
        public string @businessPhone { get; set; }
        // The 2-d business phone of a personal contact
        public string @businessPhone2 { get; set; }
        // Mobile phone of a personal contact
        public string @mobilePhone { get; set; }
        // Business fax of a personal contact
        public string @businessFax { get; set; }
        // Company phone of a personal contact
        public string @companyPhone { get; set; }
        // Assistant phone of a personal contact
        public string @assistantPhone { get; set; }
        // Car phone of a personal contact
        public string @carPhone { get; set; }
        // Other phone of a personal contact
        public string @otherPhone { get; set; }
        // Other fax of a personal contact
        public string @otherFax { get; set; }
        // Callback phone of a personal contact
        public string @callbackPhone { get; set; }
        // Email of a personal contact
        public string @email { get; set; }
        // The 2-d email of a personal contact
        public string @email2 { get; set; }
        // The 3-d email of a personal contact
        public string @email3 { get; set; }
        // Home address of a personal contact
        public ContactAddressInfo @homeAddress { get; set; }
        // Business address of a personal contact
        public ContactAddressInfo @businessAddress { get; set; }
        // Other address of a personal contact
        public ContactAddressInfo @otherAddress { get; set; }
        // Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @birthday { get; set; }
        // Web page of a personal contact
        public string @webPage { get; set; }
        // Notes of a personal contact
        public string @notes { get; set; }
    }
}
