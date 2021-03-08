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
        }

        internal RegistrationPage Open()
        {
            driver.Url ="http://automationpractice.com/index.php?controller=authentication&back=my-account";
            return this;
        }
        
        internal void SelectGender(bool gender)
        {
            if (gender == true)
                FemaleGenderSelect.Click();

            if (gender == false)
                MaleGenderSelect.Click();
        }

        internal void SelectState(string stateName)
        {
            new SelectElement(StateSelection).SelectByText(stateName);
        }

        internal void SelectDate(string day, string month, string year)
        {
            new SelectElement(DaySelection).SelectByText(day);
            new SelectElement(MonthSelection).SelectByText(month);
            new SelectElement(YearSelection).SelectByText(year);
        }



        #region PageElements
        [FindsBy(How = How.Id, Using = "email_create")]
        IWebElement EmailInput;
        [FindsBy(How = How.Id, Using = "uniform-id_gender1")]
        IWebElement MaleGenderSelect;
        [FindsBy(How = How.Id, Using = "uniform-id_gender2")]
        IWebElement FemaleGenderSelect;
        [FindsBy(How = How.Id, Using = "customer_firstname")]
        IWebElement FirstNameInput;
        [FindsBy(How = How.Id, Using = "customer_lastname")]
        IWebElement LastNameInput;
        [FindsBy(How = How.Id, Using = "passwd")]
        IWebElement PasswordInput;
        [FindsBy(How = How.Id, Using = "days")]
        IWebElement DaySelection;
        [FindsBy(How = How.Id, Using = "months")]
        IWebElement MonthSelection;
        [FindsBy(How = How.Id, Using = "years")]
        IWebElement YearSelection;
        [FindsBy(How = How.Id, Using = "firstname")]
        IWebElement AdressFirstNameInput;
        [FindsBy(How = How.Id, Using = "lastname")]
        IWebElement AdressLastNameInput;
        [FindsBy(How = How.Id, Using = "address1")]
        IWebElement AdressInput;
        [FindsBy(How = How.Id, Using = "city")]
        IWebElement CityInput;
        [FindsBy(How = How.Id, Using = "id_state")]
        IWebElement StateSelection;
        [FindsBy(How = How.Id, Using = "postcode")]
        IWebElement ZipCodeInput;
        [FindsBy(How = How.Id, Using = "id_country")]
        IWebElement CountrySelection;
        [FindsBy(How = How.Id, Using = "phone_mobile")]
        IWebElement PhoneInput;
        [FindsBy(How = How.Id, Using = "submitAccount")]
        IWebElement SubmitButton;

        #endregion
    }
}
