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
            var conf = new Nome.Configuration.Settings.Manager();
            var lang = new Nome.Configuration.Language.Manager(conf.Configuration.Language);
            lang.ReadLanguage("en");

            var common = new CommonTest();
            Assert.AreEqual(common.ParamatersTest(lang.Language), "");
        }
    }
}