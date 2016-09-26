using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nome.Configuration.Language
{
    public class Manager
    {
        public Data Language { get; private set; }

        public Manager(string lang)
        {
            this.ReadLanguage(lang);
        }

        public void ReadLanguage(string lang)
        {
            var langSr = new StreamReader(string.Concat("./lang/", lang, ".json"));
            string langJsonString = langSr.ReadToEnd();

            var langJson = JObject.Parse(langJsonString);
            this.Language = JsonConvert.DeserializeObject<Nome.Configuration.Language.Data>(langJson["data"].ToString());
        }
    }
}
