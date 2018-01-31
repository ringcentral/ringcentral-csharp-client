namespace RingCentral
{
    public partial class ClientProvisioningWebUriInfo
    {
        // Link to web page with the application description. Returned if the application needs to be updated, together with the appVersionUpgrade hint
        public string @appDownload { get; set; }
        // Link to the application distributive package. Returned if the application needs to be updated, together with the appVersionUpgrade hint
        public string @appDownloadFile { get; set; }
        // Link to express setup page (mobile application)
        public string @expressSetupMobile { get; set; }
        // Link to the RC Meetings application distributive package
        public string @meetingsAppDownload { get; set; }
        // Link to billing page (mobile application)
        public string @mobileWebBilling { get; set; }
        // Link to call handling page (mobile application)
        public string @mobileWebCallHandling { get; set; }
        // Link to international calling page (mobile application)
        public string @mobileWebInternationalCalling { get; set; }
        // Link to notifications page (mobile application)
        public string @mobileWebNotifications { get; set; }
        // Link to phone system settings page (mobile application)
        public string @mobileWebPhoneSystem { get; set; }
        // Link to reports page (mobile application)
        public string @mobileWebReporting { get; set; }
        // Link to reset password page (mobile application)
        public string @mobileWebResetPassword { get; set; }
        // Link to  Tell A Friend  page (mobile application)
        public string @mobileWebTellAFriend { get; set; }
        // Link to upgrade trial account (mobile application)
        public string @mobileWebTrialUpgrade { get; set; }
        // Link to user settings page (mobile application)
        public string @mobileWebUserSettings { get; set; }
        // Link to billing page (web application)
        public string @serviceWebBilling { get; set; }
        // Link to home page (web application)
        public string @serviceWebHome { get; set; }
        // Link to phone system settings page (web application)
        public string @serviceWebPhoneSystem { get; set; }
        // Link to reset password page (web application)
        public string @serviceWebResetPassword { get; set; }
        // Link to  Tell A Friend  page (web application)
        public string @serviceWebTellAFriend { get; set; }
        // Link to user settings page (web application)
        public string @serviceWebUserSettings { get; set; }
        // Link to sign up page (web application)
        public string @signUp { get; set; }
        // Link to support page (web application)
        public string @support { get; set; }
    }
}
