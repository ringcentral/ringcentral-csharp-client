namespace RingCentral
{
    public partial class ClientProvisioningInfo
    {
        // Links to the mobile web and Service Web resources
        public ClientProvisioningWebUriInfo @webUris { get; set; }
        // Informs client application on the required user action
        public ClientProvisioningHintsInfo @hints { get; set; }
    }
}
