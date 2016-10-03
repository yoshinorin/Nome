using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nome.Configuration.Test.Language
{
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public string ParamatersTest(Nome.Configuration.Language.Data data)
        {
            var subProperties = data.GetType().GetNestedTypes();
            foreach (var subProperty in subProperties)
            {
                var Properties = subProperty.GetProperties();
                foreach(var x in Properties)
                {
                    // TODO : Fix it. I have to get nested properties.
                    if (x.Name.Length == 0)
                    {
                        return x.Name.ToString();
                    }
                }
            }
            return "";
        }
    }
}