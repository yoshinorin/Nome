using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nome.Configuration.Test.Language
{
    [TestClass]
    public class EnglishTest
    {
        [TestMethod]
        public void ParamatersTest()
        {
            var conf = new Nome.Configuration.ConfigurationManager();
            var lang = new Nome.Configuration.LanguageManager(conf.Configuration.Language);
            lang.ReadLanguage("en");

            Assert.AreNotEqual(0, lang.Language.View.Search.Condition.Length);
            Assert.AreNotEqual(0, lang.Language.View.Search.Target.Length);
            Assert.AreNotEqual(0, lang.Language.View.Search.Word.Length);
            Assert.AreNotEqual(0, lang.Language.View.Settings.Connection.Length);
            Assert.AreNotEqual(0, lang.Language.View.Settings.UI.Length);
        }
    }
}