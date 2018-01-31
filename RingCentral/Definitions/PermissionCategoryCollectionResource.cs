namespace RingCentral
{
    public partial class PermissionCategoryCollectionResource
    {
        //
        public string @uri { get; set; }
        //
        public PermissionCategoryResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
