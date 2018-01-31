namespace RingCentral
{
    public partial class RolesCollectionResource
    {
        //
        public string @uri { get; set; }
        //
        public RoleResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
