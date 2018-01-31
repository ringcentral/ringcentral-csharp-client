namespace RingCentral
{
    public partial class ClientApiResponse
    {
        // Client application information
        public ClientApplicationInfo @client { get; set; }
        // Provisioning parameters. Available for the  detected  applications only
        public ClientProvisioningInfo @provisioning { get; set; }
    }
}
