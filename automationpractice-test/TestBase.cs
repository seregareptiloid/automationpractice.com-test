using NUnit.Framework;

namespace automationpractice_test
{
    public class TestBase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}