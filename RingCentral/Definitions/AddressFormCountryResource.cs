namespace RingCentral
{
    public partial class AddressFormCountryResource
    {
        //
        public string @uri { get; set; }
        //
        public CountryResource @country { get; set; }
        //
        public FormFieldResource[] @attributes { get; set; }
        //
        public string @emergencyNumber { get; set; }
        //
        public bool? @default { get; set; }
    }
}
