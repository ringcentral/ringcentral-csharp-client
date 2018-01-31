namespace RingCentral
{
    public partial class PermissionCollectionResource
    {
        //
        public string @uri { get; set; }
        //
        public PermissionResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
