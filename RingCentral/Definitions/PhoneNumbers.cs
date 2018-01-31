namespace RingCentral
{
    public partial class PhoneNumbers
    {
        // Canonical URI of the phone numbers resource
        public string @uri { get; set; }
        // List of phone numbers filtered by the specified criteria
        public LookupPhoneNumberInfo[] @records { get; set; }
    }
}
