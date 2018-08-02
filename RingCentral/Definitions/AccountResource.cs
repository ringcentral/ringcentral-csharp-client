namespace RingCentral
{
    public partial class AccountResource
    {
        //
        public string @companyName { get; set; }
        //
        public string @federatedName { get; set; }
        //
        public string @id { get; set; }
        //
        public PhoneNumberResource @mainNumber { get; set; }
    }
}
