namespace RingCentral
{
    public partial class SecretQuestionInfo
    {
        // Internal identifier of a question
        public string @id { get; set; }
        // Internal identifier of a question type
        public long? @questionType { get; set; }
        // Internal identifier of a question language
        public string @languageId { get; set; }
        // Text of a secret question shown to the end user
        public string @questionText { get; set; }
        // Specifies if the question is used during signup
        public bool? @showInSignUp { get; set; }
    }
}
