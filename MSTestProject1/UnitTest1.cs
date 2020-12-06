using dotNet5TestFrameworkDifference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, new Class1().MethodA());
        }
    }
}
