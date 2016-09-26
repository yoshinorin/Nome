using Newtonsoft.Json;

namespace Nome.Configuration.Settings
{
    [JsonObject("data")]
    public class Data
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("connection")]
        public Connections Connection { get; set; }

        [JsonObject("connection")]
        public class Connections
        {
            [JsonProperty("host")]
            public string Host { get; set; }

            [JsonProperty("user")]
            public string User { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }
        }
    }
}
