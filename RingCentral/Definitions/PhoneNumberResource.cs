namespace RingCentral
{
    public partial class PhoneNumberResource
    {
        // Internal identifier of a phone number
        public string @id { get; set; }
        // Brief information on a phone number country
        public CountryResource @country { get; set; }
        // Information on an extension to which the phone number is assigned
        public ExtensionResource @extension { get; set; }
        // Custom user name of a phone number, if any. Supported for numbers assigned to Auto-Receptionist, with usage type 'CompanyNumber'
        public string @label { get; set; }
        // Location (City, State). Filled for local US numbers
        public string @location { get; set; }
        // Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system = ['External', 'TollFree', 'Local'],
        public string @paymentType { get; set; }
        // Phone number
        public string @phoneNumber { get; set; }
        // Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral ,
        public string @status { get; set; }
        //
        public string @usageType { get; set; }
        // Type of a phone number
        public string @type { get; set; }
    }
}
