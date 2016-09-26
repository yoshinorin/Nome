using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Nome.Configuration;

namespace Nome.Viewer
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public Nome.Configuration.Settings.ConfigurationManager ConfigurationMng = new Nome.Configuration.Settings.ConfigurationManager();

        public static Nome.Configuration.Language.Language Language;

        protected override void OnStartup(StartupEventArgs e)
        {
            var langMng = new Nome.Configuration.Language.LanguageManager(this.ConfigurationMng.Configuration.Language);
            Language = langMng.Language;
        }
    }
}
