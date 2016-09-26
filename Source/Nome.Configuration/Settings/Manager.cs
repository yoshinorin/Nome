using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nome.Configuration.Settings
{
    public class Manager
    {
        public Configuration.Settings.Data Configuration { get; private set; }

        public Manager(string path = "./config/config.json")
        {
            var confSr = new StreamReader(path);
            string confJsonString = confSr.ReadToEnd();

            var confJson = JObject.Parse(confJsonString);
            this.Configuration = JsonConvert.DeserializeObject<Nome.Configuration.Settings.Data>(confJson["data"].ToString());
        }
    }
}