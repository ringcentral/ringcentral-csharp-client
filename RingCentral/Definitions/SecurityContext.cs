namespace RingCentral
{
    public partial class SecurityContext
    {
        //
        public Principal @userPrincipal { get; set; }
        //
        public bool? @secure { get; set; }
        //
        public string @authenticationScheme { get; set; }
    }
}
