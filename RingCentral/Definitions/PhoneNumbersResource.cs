namespace RingCentral
{
    public partial class PhoneNumbersResource
    {
        //
        public string @uri { get; set; }
        //
        public PhoneNumberResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
