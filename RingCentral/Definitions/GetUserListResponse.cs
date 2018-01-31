namespace RingCentral
{
    public partial class GetUserListResponse
    {
        // Specification links
        public string[] @schemas { get; set; }
        // 1-based index of query result
        public long? @startIndex { get; set; }
        // Results count
        public long? @totalResults { get; set; }
        // List of users with detailed info
        public UserInfo[] @Resources { get; set; }
        // Number of users displayed per page
        public long? @itemsPerPage { get; set; }
    }
}
