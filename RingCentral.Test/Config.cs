using System.IO;
using System.Reflection;
using Newtonsoft.Json;

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
                    var assemblyLocation = typeof(Config).GetTypeInfo().Assembly.Location;
                    var configFilePath = Path.Combine(Path.GetDirectoryName(assemblyLocation), "../config.json");
                    var jsonStr = File.ReadAllText(configFilePath);
                    instance = JsonConvert.DeserializeObject<Config>(jsonStr);
                }
                return instance;
            }
        }
    }

    public partial class Config
    {
        public bool? production;
        public string server;
        public string appKey;
        public string appSecret;
        public string username;
        public string extension;
        public string password;
    }
}