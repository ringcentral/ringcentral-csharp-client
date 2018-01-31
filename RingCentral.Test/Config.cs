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
                        instance.production = Environment.GetEnvironmentVariable("production") == "true";
                        instance.server = Environment.GetEnvironmentVariable("server");
                        instance.appKey = Environment.GetEnvironmentVariable("appKey");
                        instance.appSecret = Environment.GetEnvironmentVariable("appSecret");
                        instance.username = Environment.GetEnvironmentVariable("username");
                        instance.extension = Environment.GetEnvironmentVariable("extension");
                        instance.password = Environment.GetEnvironmentVariable("password");
                        instance.receiver = Environment.GetEnvironmentVariable("receiver");
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
        public string appKey { get; set; }
        public string appSecret { get; set; }
        public string username { get; set; }
        public string extension { get; set; }
        public string password { get; set; }
        public string receiver { get; set; }
    }
}