using Newtonsoft.Json;

namespace Nome.Configuration
{
    [JsonObject("language")]
    public class Language
    {
        [JsonProperty("view")]
        public View View { get; set; }
    }

    [JsonObject("view")]
    public class View
    {
        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("search")]
        public Search Search { get; set; }
    }

    [JsonObject("settings")]
    public class Settings
    {
        [JsonProperty("ui")]
        public string UI { get; set; }

        [JsonProperty("connection")]
        public string Connection { get; set; }
    }

    [JsonObject("search")]
    public class Search
    {
        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }
    }
}
