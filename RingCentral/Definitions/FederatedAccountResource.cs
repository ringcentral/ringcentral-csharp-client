namespace RingCentral
{
    public partial class FederatedAccountResource
    {
        //
        public string @companyName { get; set; }
        //
        public long? @conflictCount { get; set; }
        //
        public string @federatedName { get; set; }
        //
        public string @id { get; set; }
        //
        public string @linkCreationTime { get; set; }
        //
        public PhoneNumberResource @mainNumber { get; set; }
    }
}
