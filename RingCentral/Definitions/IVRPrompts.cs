namespace RingCentral
{
    public partial class IVRPrompts
    {
        // Link to prompts library resource
        public string @uri { get; set; }
        // List of Prompts
        public PromptInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
