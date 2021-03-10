using automationpractice_test.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace automationpractice_test
{
    class DataProvider
    {
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static IEnumerable<Customer> Customers
        {
            get
            {
                yield return new Customer()
                {

                    Gender = false,
                    Email = Guid.NewGuid().ToString().Substring(0, 7) + "@mail.com",
                    Password = "parol123",
                    Name = RandomString(6),
                    Surname = RandomString(5),
                    BirthDay = "15",
                    BirthMonth = "12",
                    BirthYear = "2000",
                    Adress = "Home",
                    City = "Default City",
                    State = "Iowa",
                    PhoneNumber = "123456789",
                    ZipCode = "12345",
                };
            }
        }
    }
}
