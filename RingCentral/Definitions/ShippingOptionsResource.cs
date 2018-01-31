namespace RingCentral
{
    public partial class ShippingOptionsResource
    {
        //
        public string @uri { get; set; }
        //
        public ShippingOptionResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
