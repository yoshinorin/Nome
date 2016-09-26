using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nome.Configuration.Settings
{
    public class ConfigurationManager
    {
        public Configuration.Settings.Settings Configuration { get; private set; }

        public ConfigurationManager(string path = "./config/config.json")
        {
            var confSr = new StreamReader(path);
            string confJsonString = confSr.ReadToEnd();

            var confJson = JObject.Parse(confJsonString);
            this.Configuration = JsonConvert.DeserializeObject<Nome.Configuration.Settings.Settings>(confJson["configuration"].ToString());
        }
    }
}