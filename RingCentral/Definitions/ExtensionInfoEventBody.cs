namespace RingCentral
{
    public partial class ExtensionInfoEventBody
    {
        // Internal identifier of an extension
        public string @extensionId { get; set; }
        // Type of extension info change
        public string @eventType { get; set; }
        // Returned for 'Update' event type only. The possible values are: /nAccountInfo - change of account parameters/nExtensionInfo - change of contact info, service features, departments, status/nPhoneNumber - change of phone numbers/nRole - change of permissions/nProfileImage - change of profile image
        public string[] @hints { get; set; }
        // Internal identifier of a subscription owner extension
        public string @ownerId { get; set; }
    }
}
