namespace RingCentral
{
    public partial class CreateAccountRequest
    {
        // Main account VoIP phone number, either Local or Toll-Free. Cannot be Fax Only. Obtained via lookup/reserve API
        public string @mainNumber { get; set; }
        // Operator's extension information. This extension will receive all calls and messages intended for the operator
        public GetExtensionInfoResponse @operator { get; set; }
        // Partner identifier for this account
        public string @partnerId { get; set; }
        // Promotion code to calculate a discount
        public string @promotionCode { get; set; }
        // Internal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time
        public string @reservationId { get; set; }
        // Account service information, brand identifier and service plan
        public GetServiceInfoResponse @serviceInfo { get; set; }
        // The status with which an account is created. The default value is 'Initial'
        public string @status { get; set; }
        // Account sign up data
        public AccountSignupInfoRequest @signupInfo { get; set; }
    }
}
