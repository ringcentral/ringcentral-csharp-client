namespace RingCentral
{
    public partial class ExtensionSecretQuestionInfo
    {
        // Internal identifier of a secret question
        public string @id { get; set; }
        // Link to a secret question resource
        public string @uri { get; set; }
        // Answer to a secret question
        public string @answer { get; set; }
    }
}
