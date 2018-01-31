namespace RingCentral
{
    public partial class DictionaryShippingOptions
    {
        // Quantity of devices to ship
        public long? @quantity { get; set; }
        // Price for shipping with the specified method (depending on the quantity value)
        public long? @price { get; set; }
        // Shipping method description
        public ShippingMethod @method { get; set; }
    }
}
