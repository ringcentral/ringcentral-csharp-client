namespace RingCentral
{
    public partial class UserSearchResponse
    {
        // user list
        public UserResponse[] @Resources { get; set; }
        //
        public long? @itemsPerPage { get; set; }
        //
        public string[] @schemas { get; set; }
        //
        public long? @startIndex { get; set; }
        //
        public long? @totalResults { get; set; }
    }
}
