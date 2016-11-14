namespace RingCentral
{
    public partial class DeliveryMode
    {
        // Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        public string @transportType { get; set; }
        // Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always "false"
        public bool? @encryption { get; set; }
        // PubNub channel name. For APNS transport type - internal identifier of a device "device_token"
        public string @address { get; set; }
        // PubNub subscriber credentials required to subscribe to the channel
        public string @subscriberKey { get; set; }
        // PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)
        public string @secretKey { get; set; }
        // Encryption algorithm 'AES' (for PubNub transport type only)
        public string @encryptionAlgorithm { get; set; }
        // Key for notification message decryption (for PubNub transport type only)
        public string @encryptionKey { get; set; }
    }
}
