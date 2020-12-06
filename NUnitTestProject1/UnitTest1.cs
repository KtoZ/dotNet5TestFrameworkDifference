using dotNet5TestFrameworkDifference;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, new Class1().MethodA());
        }
    }
}