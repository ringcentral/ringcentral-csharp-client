namespace RingCentral
{
    public partial class NotificationDeliveryModeRequest
    {
        // Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        public string @transportType { get; set; }
        // Mandatory for 'APNS' and 'WebHook' transport types. For 'APNS' - internal identifier of a device 'device_token' for 'WebHook' - URL of a consumer service (cannot be changed during subscription update)
        public string @address { get; set; }
        // Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is 'True' (even if specified as 'false'). If request contains only message event filters the value by default is 'False'
        public bool? @encryption { get; set; }
        // For 'PubNub/APNS' and 'PubNub/GCM' transport types. Name of a certificate
        public string @certificateName { get; set; }
        // For 'PubNub/APNS' and 'PubNub/GCM' transport types. Identifier of a registration
        public string @registrationId { get; set; }
        // For 'Webhook' transport type. Subscription verification key ensuring data security
        public string @verificationToken { get; set; }
    }
}
