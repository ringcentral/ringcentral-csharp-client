namespace RingCentral
{
    public partial class ExtensionUserCredentailsRequest
    {
        // User password of an extension
        public string @password { get; set; }
        // User pin of an extension
        public string @ivrPin { get; set; }
        //
        public ExtensionSecretQuestionInfo @secretQuestion { get; set; }
    }
}
