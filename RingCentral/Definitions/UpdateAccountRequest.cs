namespace RingCentral
{
    public partial class UpdateAccountRequest
    {
        // Target account status. For account activation - 'Unconfirmed'. For account confirmation - 'Confirmed'. For changing account status - 'Confirmed' or 'Disabled' = ['Unconfirmed', 'Confirmed', 'Disabled'],
        public string @status { get; set; }
        // Status information (reason, comment, lifetime). Returned for 'Disabled' status only
        public AccountStatusInfo @statusInfo { get; set; }
        // Email notifications setting
        public TransitionInfo @transitionInfo { get; set; }
        // Additional account identifier, developed and applied on the client side
        public string @partnerId { get; set; }
        // Account service information, including brand, service plan and billing plan
        public AccountServiceInfo @serviceInfo { get; set; }
        // Account level region data (web service Auto-Receptionist settings)
        public RegionalSettings @regionalSettings { get; set; }
        // Identifier of extension to be set as operator for account
        public string @operatorId { get; set; }
        // Account sign up data
        public SignupInfoResource @signupInfo { get; set; }
    }
}
