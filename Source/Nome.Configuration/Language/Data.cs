using Newtonsoft.Json;

namespace Nome.Configuration.Language
{
    [JsonObject("language")]
    public class Data
    {
        [JsonProperty("view")]
        public Views View { get; set; }

        [JsonObject("view")]
        public class Views
        {
            [JsonProperty("settings")]
            public Settings Settings { get; set; }

            [JsonProperty("language")]
            public Language Language { get; set; }

            [JsonProperty("ui")]
            public UI UI { get; set; }

            [JsonProperty("connection")]
            public Connection Connection { get; set; }

            [JsonProperty("search")]
            public Search Search { get; set; }

            [JsonProperty("others")]
            public Others Others { get; set; }

            [JsonProperty("about")]
            public About About { get; set; }
        }

        [JsonObject("settings")]
        public class Settings
        {
            [JsonProperty("title")]
            public string Title { get; set; }
        }

        [JsonObject("language")]
        public class Language
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }

        [JsonObject("ui")]
        public class UI
        {
            [JsonProperty("title")]
            public string Title { get; set; }
        }

        [JsonObject("connection")]
        public class Connection
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("destination")]
            public string Destination { get; set; }
        }

        [JsonObject("search")]
        public class Search
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("addCondition")]
            public string AddCondition { get; set; }

            [JsonProperty("target")]
            public string Target { get; set; }

            [JsonProperty("word")]
            public string Word { get; set; }

            [JsonProperty("condition")]
            public string Condition { get; set; }
        }

        [JsonObject("others")]
        public class Others
        {
            [JsonProperty("title")]
            public string Title { get; set; }
        }

        [JsonObject("about")]
        public class About
        {
            [JsonProperty("title")]
            public string Title { get; set; }
        }
    }
}
