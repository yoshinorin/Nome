using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nome.LDAP.Test
{
    [TestClass]
    public class ObjectClassServiceParseTest
    {
        [TestMethod]
        public void GetUserTest()
        {
            Assert.AreEqual("ユーザー",ObjectClassService.NameByLanguage(ObjectClassTypeEnum.user));
        }

        [TestMethod]
        public void GetComputerTest()
        {
            Assert.AreEqual("コンピューター", ObjectClassService.NameByLanguage(ObjectClassTypeEnum.computer));
        }
    }
}
