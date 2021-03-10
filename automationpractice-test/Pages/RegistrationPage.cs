using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Text;

namespace automationpractice_test.Pages
{
    class RegistrationPage : Page
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        internal RegistrationPage Open()
        {
            driver.Url ="http://automationpractice.com/index.php?controller=authentication&back=my-account";
            return this;
        }
        
        internal void SelectGender(bool gender)
        {
            if (gender == true)
                chkFemaleGender.Click();

            if (gender == false)
                chkMaleGender.Click();
        }

        internal void SelectState(string stateName)
        {
            new SelectElement(ddlStateSelection).SelectByText(stateName);
        }

        internal void SelectBirthDate(string day, string month, string year)
        {
            new SelectElement(dtpDay).SelectByValue(day);
            new SelectElement(dtpMonth).SelectByValue(month);
            new SelectElement(dtpYear).SelectByValue(year);
        }

        #region PageElements
        internal IWebElement txtEmail => driver.FindElement(By.Id("email_create"));
        internal IWebElement chkMaleGender => driver.FindElement(By.Id("uniform-id_gender1"));
        internal IWebElement chkFemaleGender => driver.FindElement(By.Id("uniform-id_gender2"));
        internal IWebElement txtFirstName => driver.FindElement(By.Id("customer_firstname"));
        internal IWebElement txtLastName => driver.FindElement(By.Id("customer_lastname"));
        internal IWebElement txtPassword => driver.FindElement(By.Id("passwd"));
        internal IWebElement dtpDay => driver.FindElement(By.Id("days"));
        internal IWebElement dtpMonth => driver.FindElement(By.Id("months"));
        internal IWebElement dtpYear => driver.FindElement(By.Id("years"));
        internal IWebElement dtpAdressFirstName => driver.FindElement(By.Id("firstname"));
        internal IWebElement dtpAdressLastName => driver.FindElement(By.Id("lastname"));
        internal IWebElement dtpAdress => driver.FindElement(By.Id("address1"));
        internal IWebElement dtpCityInput => driver.FindElement(By.Id("city"));
        internal IWebElement ddlStateSelection => driver.FindElement(By.Id("id_state"));
        internal IWebElement txtZipCode => driver.FindElement(By.Id("postcode"));
        internal IWebElement ddlCountry => driver.FindElement(By.Id("id_country"));
        internal IWebElement txtPhone => driver.FindElement(By.Id("phone_mobile"));
        internal IWebElement btnRegistration => driver.FindElement(By.Id("submitAccount"));
        internal IWebElement btnCreate => driver.FindElement(By.Id("SubmitCreate"));

        #endregion
    }
}
