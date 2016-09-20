using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nome.Viewer.Services;

namespace Nome.Viewer.Test
{
    [TestClass]
    public class SearchConditionParseTest
    {
        [TestMethod]
        public void GetEqualTest()
        {
            Assert.AreEqual("一致", SearchConditionService.NameByLanguage(SearchConditionEnum.equal));
        }

        [TestMethod]
        public void GetFowardMatchTest()
        {
            Assert.AreEqual("前方一致", SearchConditionService.NameByLanguage(SearchConditionEnum.forwardmatch));
        }

        [TestMethod]
        public void GetBackwardMatchTest()
        {
            Assert.AreEqual("後方一致", SearchConditionService.NameByLanguage(SearchConditionEnum.backwardmatch));
        }

        [TestMethod]
        public void GetContainsTest()
        {
            Assert.AreEqual("含む", SearchConditionService.NameByLanguage(SearchConditionEnum.contains));
        }
    }
}
