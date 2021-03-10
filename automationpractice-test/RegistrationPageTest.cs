using automationpractice_test.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace automationpractice_test
{
    class RegistrationPageTest : TestBase
    {
        [Test, TestCaseSource(typeof(DataProvider), "Customers")]
        public void RegistrationTest(Customer customer)
        {
            app.RegisterNewCustomer(customer);
            Assert.IsTrue(app.IsRegistrationSuccessful(),"Registration is failed");
            app.Quit();
        }
    }
}
