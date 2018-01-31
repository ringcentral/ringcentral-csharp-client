namespace RingCentral
{
    public partial class SecretQuestionsInfoResource
    {
        //
        public string @uri { get; set; }
        //
        public SecretQuestionInfoResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
