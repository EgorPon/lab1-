using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Teacher : Human
    {
        private int counter;

        private List<Student> student = new List<Student>();
        public Teacher(string Name, string Surname, int Age, string Country, string Region, string City, string Street) : base(Name, Surname, Age, Country, Region, City, Street)
        {
            counter = 0;

        }

        public void Add(Student person)
        {

            student.Add( person);
            counter++;
            Console.WriteLine("Successfully added! ");

        }
        public void Remove(Student person)
        {
            if (counter == 0)
            {
                Console.WriteLine("List is empty!!!");
            }
            else
            {
                student.Remove(person);
                counter--;

                Console.WriteLine("Successfully revomed!");
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Teacher: "); 
            base.GetInfo();
          
        }
        public void StudentInfo()
        {
            if (counter == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine("Students list: ");
                foreach (Student a in student)
                {

                    a.GetInfo();

                }
            }

        }


    }
}



