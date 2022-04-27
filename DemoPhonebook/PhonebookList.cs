using System;
using System.Collections;

namespace DemoPhonebook{

    public class PhonebookList{

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public PhonebookList(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public PhonebookList(){}
    }
}