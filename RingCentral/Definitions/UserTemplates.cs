namespace RingCentral
{
    public partial class UserTemplates
    {
        // Link to user templates resource
        public string @uri { get; set; }
        // List of user templates
        public TemplateInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
