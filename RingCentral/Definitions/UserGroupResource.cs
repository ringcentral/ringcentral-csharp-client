namespace RingCentral
{
    public partial class UserGroupResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @displayName { get; set; }
        //
        public string @description { get; set; }
        //
        public UserGroupManagerResource[] @managers { get; set; }
        //
        public ExtensionIdResource[] @members { get; set; }
    }
}
