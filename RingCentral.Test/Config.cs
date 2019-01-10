using Newtonsoft.Json;
using System;

namespace RingCentral.Test
{
    public partial class Config
    {
        private static Config instance = null;
        private Config() { }

        internal static Config Instance
        {
            get
            {
                if (instance == null)
                {
                    if (System.IO.File.Exists("config.json"))
                    {
                        var jsonStr = System.IO.File.ReadAllText("config.json");
                        instance = JsonConvert.DeserializeObject<Config>(jsonStr);
                    }
                    else
                    {
                        instance = new Config();
                        instance.production = Environment.GetEnvironmentVariable("RINGCENTRAL_PRODUCTION") == "true";
                        instance.server = Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL");
                        instance.clientId = Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID");
                        instance.clientSecret = Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET");
                        instance.username = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME");
                        instance.extension = Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION");
                        instance.password = Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD");
                        instance.receiver = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER");
                    }
                }
                return instance;
            }
        }
    }

    public partial class Config
    {
        public bool? production { get; set; }
        public string server { get; set; }
        public string clientId { get; set; }
        public string clientSecret { get; set; }
        public string username { get; set; }
        public string extension { get; set; }
        public string password { get; set; }
        public string receiver { get; set; }
    }
}