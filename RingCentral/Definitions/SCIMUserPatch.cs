namespace RingCentral
{
    public partial class SCIMUserPatch
    {
        // patch operations list
        public PatchOperationInfo[] @Operations { get; set; }
        //
        public string[] @schemas { get; set; }
    }
}
