namespace RingCentral
{
    public partial class ProvisionPhoneNumberRequest
    {
        // Information on extension which the phone number is added to, only for provisioning extension-level numbers
        public ExtensionInfoProvisionPhoneNumbers @extensionId { get; set; }
        // Phone number to purchase returned in E.164 (11-digits) format
        public string @phoneNumber { get; set; }
        // Internal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time
        public string @reservationId { get; set; }
        // Custom user name of a phone number, if any. Supported for numbers assigned to Auto-Receptionist, with usage type 'CompanyNumber
        public string @label { get; set; }
        // Usage type of a phone number. The default value is 'DirectNumber'
        public string @usageType { get; set; }
        // Type of a phone number
        public string @type { get; set; }
        //  Vanity pattern that was used to find this number. It should be passed as if it was returned from the Number Lookup call
        public string @vanityPattern { get; set; }
    }
}
