namespace RingCentral
{
    public partial class ClientApplicationInfo
    {
        // 'True', if the server succeeded detecting application info, sufficient to return provisioning info
        public bool? @detected { get; set; }
        // The value of 'User-Agent' header, as it was passed in request
        public string @userAgent { get; set; }
        // Application identifier (from authorization session)
        public string @appId { get; set; }
        // Application name (from authorization session, but must match 'User-Agent')
        public string @appName { get; set; }
        // Application version (parsed from 'User-Agent')
        public string @appVersion { get; set; }
        // Application platform operation system (parsed from 'User-Agent': Windows, MacOS, Android, iOS
        public string @appPlatform { get; set; }
        // Application platform operation system version (parsed from 'User-Agent')
        public string @appPlatformVersion { get; set; }
        // Locale, parsed from 'Accept-Language'. Currently en-GB and en-US locales are supported. The default value is en-US
        public string @locale { get; set; }
    }
}
