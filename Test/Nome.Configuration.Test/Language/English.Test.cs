using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nome.Configuration.Test.Language
{
    [TestClass]
    public class EnglishTest
    {
        private static StreamReader sr = new StreamReader("./config/config.json");
        private string jsonString = sr.ReadToEnd();

        [TestMethod]
        public void ParamatersTest()
        {
            var conf = new Nome.Configuration.Manager(jsonString);
            conf.ReadLanguage("en");

            Assert.AreNotEqual(0, conf.Language.View.Search.Condition.Length);
            Assert.AreNotEqual(0, conf.Language.View.Search.Target.Length);
            Assert.AreNotEqual(0, conf.Language.View.Search.Word.Length);
            Assert.AreNotEqual(0, conf.Language.View.Settings.Connection.Length);
            Assert.AreNotEqual(0, conf.Language.View.Settings.UI.Length);
        }
    }
}