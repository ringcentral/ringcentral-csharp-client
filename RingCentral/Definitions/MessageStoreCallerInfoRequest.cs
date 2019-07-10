namespace RingCentral
{
    public partial class MessageStoreCallerInfoRequest
    {
        // Phone number in E.164 format
        public string @phoneNumber { get; set; }
        
        public string @name { get; set; }
        
        public string @location { get; set; }
    }
}
