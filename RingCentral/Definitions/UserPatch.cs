namespace RingCentral
{
    public partial class UserPatch
    {
        // patch operations list
        public PatchOperation[] @Operations { get; set; }
        //
        public string[] @schemas { get; set; }
    }
}
