namespace RingCentral
{
    public partial class SessionResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @accountId { get; set; }
        //
        public string @extensionId { get; set; }
        //
        public string @creationTime { get; set; }
        //
        public string @clientId { get; set; }
        //
        public ApplicationResource @application { get; set; }
    }
}
