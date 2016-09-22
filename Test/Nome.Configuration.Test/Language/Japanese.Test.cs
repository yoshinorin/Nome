using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nome.Configuration.Test.Language
{
    [TestClass]
    public class JapaneseTest
    {
        [TestMethod]
        public void ParamatersTest()
        {
            var conf = new Nome.Configuration.Manager();
            conf.ReadLanguage("ja");

            Assert.AreNotEqual(0, conf.Language.View.Search.Condition.Length);
            Assert.AreNotEqual(0, conf.Language.View.Search.Target.Length);
            Assert.AreNotEqual(0, conf.Language.View.Search.Word.Length);
            Assert.AreNotEqual(0, conf.Language.View.Settings.Connection.Length);
            Assert.AreNotEqual(0, conf.Language.View.Settings.UI.Length);
        }
    }
}