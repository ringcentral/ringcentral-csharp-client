using Newtonsoft.Json;
using System.IO;

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
                    var jsonStr = File.ReadAllText("config.json");
                    instance = JsonConvert.DeserializeObject<Config>(jsonStr);
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