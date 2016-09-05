using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nome
{
    public class ConfigurationManager
    {
        public Configuration Configuration { get; private set; }

        public ConfigurationManager(string input)
        {
            var json = JObject.Parse(input);
            this.Configuration = JsonConvert.DeserializeObject<Nome.Configuration>(json["configuration"].ToString());
        }
    }

    [JsonObject("configuration")]
    public class Configuration
    {
        [JsonProperty("connection")]
        public Connection Connection { get; set; }
    }

    [JsonObject("connection")]
    public class Connection
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    } 
}
