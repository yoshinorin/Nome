using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nome.LDAP.Connection;

namespace Nome.LDAP.Test
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void ConnectionADTest()
        {
            var ad = new ActiveDirectory(null);
        }
    }
}
