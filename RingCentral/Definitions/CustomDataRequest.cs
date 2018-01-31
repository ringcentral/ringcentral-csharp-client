namespace RingCentral
{
    public partial class CustomDataRequest
    {
        // Custom data access key. Optional. If specified, must match the custom key in the URL
        public string @id { get; set; }
        // Description of custom data. Mandatory for create, if there is no attachment specified. Maximum length is limited to 256 symbols
        public string @value { get; set; }
    }
}
