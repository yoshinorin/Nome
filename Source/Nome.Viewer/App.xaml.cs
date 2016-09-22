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
        public Nome.Viewer.Services.ResourcesService Resources = new Nome.Viewer.Services.ResourcesService();
        public string x = "";
    }
}
