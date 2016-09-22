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
        public Nome.Configuration.ConfigurationManager ConfigurationMng = new Nome.Configuration.ConfigurationManager();

        public static Nome.Configuration.Language Language;

        protected override void OnStartup(StartupEventArgs e)
        {
            var langMng = new Nome.Configuration.LanguageManager(this.ConfigurationMng.Configuration.Language);
            Language = langMng.Language;
        }
    }
}
