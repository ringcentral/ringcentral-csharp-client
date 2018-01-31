namespace RingCentral
{
    public partial class ModifyAccountBusinessAddressRequest
    {
        // Company business name
        public string @company { get; set; }
        // Company business email address
        public string @email { get; set; }
        // Company business address
        public BusinessAddressInfo @businessAddress { get; set; }
    }
}
