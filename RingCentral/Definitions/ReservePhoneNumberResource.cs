namespace RingCentral
{
    public partial class ReservePhoneNumberResource
    {
        // Phone number in E.164
        public string @phoneNumber { get; set; }
        // Domestic format of a phone number
        public string @formattedNumber { get; set; }
        //  Datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. No value means that number is not reserved anymore
        public string @reservedTill { get; set; }
        // nternal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time
        public string @reservationId { get; set; }
        // Phone number status = ['Enabled', 'Pending', 'Disabled'],
        public string @status { get; set; }
        // The error code in case of reservation/un-reservation failure = ['NumberIsAlreadyProvisioned', 'NumberReserved', 'NumberNotAvailable']
        public string @error { get; set; }
    }
}
