namespace RingCentral
{
    public partial class UserTransitionInfo
    {
        // Specifies if an activation email is automatically sent to new users (Not Activated extensions) or not
        public bool? @sendWelcomeEmailsToUsers { get; set; }
        // Supported for account confirmation. Specifies whether welcome email is sent
        public bool? @sendWelcomeEmail { get; set; }
    }
}
