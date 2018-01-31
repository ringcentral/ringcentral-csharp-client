namespace RingCentral
{
    public partial class TransitionInfo
    {
        // Supported for account confirmation. Specifies whether welcome email is sent. The default value is 'True'
        public bool? @sendWelcomeEmail { get; set; }
        // Supported for account activation. Specifies whether confirmation email is sent. The default value is 'True'
        public bool? @sendConfirmationEmail { get; set; }
        // Specifies whether devices are shipped after successful account confirmation. The default value is 'True'
        public bool? @shipDevices { get; set; }
        // Supported for account confirmation. Activation email hash code
        public string @activationEmailHash { get; set; }
    }
}
