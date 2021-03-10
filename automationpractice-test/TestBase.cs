using automationpractice_test.App;
using NUnit.Framework;

namespace automationpractice_test
{
    public class TestBase
    {
        public Application app;
        [SetUp]
        public void Setup()
        {
            app = new Application();
        }
    }
}