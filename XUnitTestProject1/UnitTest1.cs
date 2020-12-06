using dotNet5TestFrameworkDifference;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, new Class1().MethodA());
        }
    }
}
