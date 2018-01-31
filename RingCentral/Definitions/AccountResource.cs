namespace RingCentral
{
    public partial class AccountResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public AccountServiceInfoResource @serviceInfo { get; set; }
        //
        public string @partnerId { get; set; }
        //
        public ExtensionResource @operator { get; set; }
        //
        public string @mainNumber { get; set; }
        //
        public string @reservationId { get; set; }
        //
        public string @sessionId { get; set; }
        //
        public string @status { get; set; }
        //
        public StatusInfo @statusInfo { get; set; }
        //
        public SignupInfoResource @signupInfo { get; set; }
        //
        public string @setupWizardState { get; set; }
        //
        public string[] @testerFlags { get; set; }
        //
        public string @promotionCode { get; set; }
    }
}
