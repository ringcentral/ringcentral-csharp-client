namespace RingCentral
{
    public partial class AnsweringRulesResource
    {
        //
        public string @uri { get; set; }
        //
        public AnsweringRuleResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
