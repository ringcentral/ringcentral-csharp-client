namespace RingCentral
{
    public partial class ExternalUserInfo
    {
        // User type of a meeting account
        public string @accountId { get; set; }
        // Meeting account user identifier
        public string @userId { get; set; }
        // Meeting account user token
        public string @userToken { get; set; }
        // Meeting account user type
        public long? @userType { get; set; }
    }
}
