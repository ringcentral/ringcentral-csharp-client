namespace RingCentral
{
    public partial class TokenInfo
    {
        // Access token to pass to subsequent API requests
        public string @access_token { get; set; }
        // Issued access token TTL (time to live), in seconds
        public long? @expires_in { get; set; }
        // Refresh token to get a new access token, when the issued one expires
        public string @refresh_token { get; set; }
        // Issued refresh token TTL (time to live), in seconds
        public long? @refresh_token_expires_in { get; set; }
        // List of permissions allowed with this access token, white-space separated
        public string @scope { get; set; }
        // Type of token. The only possible value supported is Bearer. This value should be used when specifying access token in Authorization header of subsequent API requests
        public string @token_type { get; set; }
        // Extension identifier
        public string @owner_id { get; set; }
    }
}
