namespace Nome.Viewer.Services
{
    public class ResourcesService
    {
        private static readonly ResourcesService _current = new ResourcesService();

        public static ResourcesService CurrentResources { get { return _current; } }

        private readonly Configuration.Configuration _configuration = new Nome.Configuration.Configuration();

        private readonly Configuration.Language _language = new Nome.Configuration.Language();

        public Configuration.Configuration Configuration { get { return this._configuration; } }

        public Configuration.Language Language { get { return this._language; } }

        public ResourcesService()
        {
            var conf = new Configuration.Manager();
            this._configuration = conf.Configuration;
            this._language = conf.Language;
        }
    }
}
