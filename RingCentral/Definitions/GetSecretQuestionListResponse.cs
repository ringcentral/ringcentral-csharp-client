namespace RingCentral
{
    public partial class GetSecretQuestionListResponse
    {
        // Canonical URI of a question list resource
        public string @uri { get; set; }
        // List of secret questions with their descriptions
        public SecretQuestionInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
