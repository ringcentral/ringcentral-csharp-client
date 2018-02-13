namespace RingCentral
{
    public partial class SCIMErrorResponse
    {
        // detail error message
        public string @detail { get; set; }
        //
        public string[] @schemas { get; set; }
        // bad request type when status code is 400
        public string @scimType { get; set; }
        // same as HTTP status code, e.g. 400, 401, etc.
        public string @status { get; set; }
    }
}
