using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nome.Configuration.Language
{
    public class LanguageManager
    {
        public Language Language { get; private set; }

        public LanguageManager(string lang)
        {
            this.ReadLanguage(lang);
        }

        public void ReadLanguage(string lang)
        {
            var langSr = new StreamReader(string.Concat("./lang/", lang, ".json"));
            string langJsonString = langSr.ReadToEnd();

            var langJson = JObject.Parse(langJsonString);
            this.Language = JsonConvert.DeserializeObject<Nome.Configuration.Language.Language>(langJson["language"].ToString());
        }
    }
}
