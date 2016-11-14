namespace RingCentral
{
    public partial class PhoneNumberInfo
    {
        // Internal identifier of a phone number
        public long? @id { get; set; }
        // Brief information on a phone number country
        public CountryInfo @country { get; set; }
        // Information on the extension, to which the phone number is assigned. Returned only for the request of Account phone number list
        public PhoneNumberInfo_ExtensionInfo @extension { get; set; }
        // Indicates if this phone number is enabled to appear as CallerId and/or to send outbound SMS from it. Returned only for the request of Extension phone number list
        public string[] @features { get; set; }
        // Location (City, State). Filled for local US numbers
        public string @location { get; set; }
        // Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        public string @paymentType { get; set; }
        // Phone number
        public string @phoneNumber { get; set; }
        // Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        public string @status { get; set; }
        // Phone number type
        public string @type { get; set; }
        // Usage type of the phone number
        public string @usageType { get; set; }
    }
}
