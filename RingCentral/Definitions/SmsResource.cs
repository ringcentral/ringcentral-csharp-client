namespace RingCentral
{
    public partial class SmsResource
    {
        //
        public CountryResource @country { get; set; }
        //
        public CallerInfo[] @to { get; set; }
        //
        public CallerInfo @from { get; set; }
        //
        public string @text { get; set; }
    }
}
