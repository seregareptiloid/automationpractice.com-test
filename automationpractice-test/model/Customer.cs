using System;
using System.Collections.Generic;
using System.Text;

namespace automationpractice_test.model
{
    public class Customer
    {
        public bool Gender { get; internal set; }
        public string Email { get; internal set; }
        public string Password { get; internal set; }
        public string Name { get; internal set; }
        public string Surname { get; internal set; }
        public string BirthDay { get; internal set; }
        public string BirthMonth { get; internal set; }
        public string BirthYear { get; internal set; }
        public string Adress { get; internal set; }
        public string City { get; internal set; }
        public string State { get; internal set; }
        public string PhoneNumber { get; internal set; }

    }
}
