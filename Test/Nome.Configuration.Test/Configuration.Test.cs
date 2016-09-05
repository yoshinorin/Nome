using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nome.Configuration.Test
{
    [TestClass]
    public class ConfigurationTest
    {
        private static StreamReader sr = new StreamReader("../../../Source/Nome.Configuration/config/config.json");
        private string jsonString = sr.ReadToEnd();

        [TestMethod]
        public void ConstractorTest()
        {
            var conf = new Nome.ConfigurationManager(jsonString);
            Assert.AreEqual("LDAP://127.0.0.1/dc=maxcrc,dc=com", conf.Configuration.Connection.Host);
        }
    }
}
