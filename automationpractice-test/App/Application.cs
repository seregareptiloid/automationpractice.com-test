using automationpractice_test.Model;
using automationpractice_test.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace automationpractice_test.App
{
   public class Application
    {
        private IWebDriver driver;
        private RegistrationPage registrationPage;
        WebDriverWait wait;

        public Application()
        {
            driver = new ChromeDriver();
            registrationPage = new RegistrationPage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }

        public void RegisterNewCustomer(Customer customer)
        {
            registrationPage.Open();
            registrationPage.txtEmail.SendKeys(customer.Email);
            registrationPage.btnCreate.Click();
            registrationPage.SelectGender(customer.Gender);
            registrationPage.txtFirstName.SendKeys(customer.Name);
            registrationPage.txtLastName.SendKeys(customer.Surname);
            registrationPage.txtPassword.SendKeys(customer.Password);
            registrationPage.SelectBirthDate(customer.BirthDay, customer.BirthMonth, customer.BirthYear);
            registrationPage.dtpAdressFirstName.SendKeys(customer.Name);
            registrationPage.dtpAdressLastName.SendKeys(customer.Surname);
            registrationPage.dtpAdress.SendKeys(customer.Adress);
            registrationPage.dtpCityInput.SendKeys(customer.City);
            registrationPage.SelectState(customer.State);
            registrationPage.txtZipCode.SendKeys(customer.ZipCode);
            registrationPage.txtPhone.SendKeys(customer.PhoneNumber);
            registrationPage.btnRegistration.Click();
        }

        public bool IsRegistrationSuccessful()
        {
            if (driver.FindElements(By.CssSelector("[id=my-account]")).Count>0)
            {
                return true;
            }
            return false;
        }

        public void Quit()
        {
            driver.Quit();
        }

    }
}
