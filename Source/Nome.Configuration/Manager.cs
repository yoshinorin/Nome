using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nome.Configuration
{
    public class Manager
    {
        public Configuration Configuration { get; private set; }

        public Language Language { get; private set; }

        public Manager(string input)
        {
            var confJson = JObject.Parse(input);
            this.Configuration = JsonConvert.DeserializeObject<Nome.Configuration.Configuration>(confJson["configuration"].ToString());

            this.ReadLanguage(this.Configuration.Language);
        }

        public void ReadLanguage(string lang)
        {
            var langSr = new StreamReader(string.Concat("./lang/", lang, ".json"));
            string langJsonString = langSr.ReadToEnd();

            var langJson = JObject.Parse(langJsonString);
            this.Language = JsonConvert.DeserializeObject<Nome.Configuration.Language>(langJson["language"].ToString());
        }
    }
}