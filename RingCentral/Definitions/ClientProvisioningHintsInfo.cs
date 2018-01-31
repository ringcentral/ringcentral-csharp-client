namespace RingCentral
{
    public partial class ClientProvisioningHintsInfo
    {
        // Trial account expiration. Returned for trial accounts only
        public ClientProvisioningHintInfo @trialState { get; set; }
        // User credentials expiration
        public ClientProvisioningHintInfo @userCredentialState { get; set; }
        // Application version update. Returned only if the client current version is older than the latest version. 'actionRequired': 'true' means the application requires force updating to the latest version
        public ClientProvisioningHintInfo @appVersionUpgrade { get; set; }
    }
}
