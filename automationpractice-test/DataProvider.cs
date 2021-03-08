using automationpractice_test.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace automationpractice_test
{
    class DataProvider
    {
        public static IEnumerable<Customer> Customers
        {
            get
            {
                yield return new Customer()
                {
                    Gender = false,
                    Email = Guid.NewGuid().ToString().Substring(0, 7) + "@mail.com",
                    Password = "parol123",
                    Name = Guid.NewGuid().ToString().Substring(0, 7),
                    Surname = Guid.NewGuid().ToString().Substring(0, 7),
                    BirthDay = "15",
                    BirthMonth = "February",
                    BirthYear = "2000",
                    Adress = "Home",
                    City = "Default City",
                    State = "Iowa",
                    PhoneNumber = "123456789",
                };
            }
        }
    }
}
