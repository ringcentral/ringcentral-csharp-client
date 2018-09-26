namespace RingCentral
{
    public partial class ForwardingNumberResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @phoneNumber { get; set; }
        //
        public string @label { get; set; }
        //
        public string[] @features { get; set; }
        //
        public string @flipNumber { get; set; }
        // Forwarding phone number type
        public string @type { get; set; }
    }
}
