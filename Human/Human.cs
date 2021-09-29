using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Human
    {
        private string name;
        private string surname;
        private int age;

        private Address address = new Address();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Human() { }
        public Human(string Name, string Surname, int Age, string Country, string Region, string City, string Street)
        {
            name = Name;
            surname = Surname;
            age = Age;
            address.Address1(Country, Region, City, Street);
        }
        public virtual void GetInfo()
        {
           
          
            Console.WriteLine($"Имя {Name} Фамилия {Surname} Возраст {Age}"); address.GetInfo();
        }
    }
}
