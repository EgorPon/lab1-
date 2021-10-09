using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Human
{
    class Teacherlist
    {
        private int counter = 0;
        private List<Teacher> teachers = new List<Teacher>();
        public void Add(Teacher teacher)
        {
            teachers.Add(teacher);
            counter++;
            Console.WriteLine("Successfully added");
        }
        public void Remove(Teacher teacher)
        {

            if (counter == 0)
            {
                Console.WriteLine("List is empty!!!");
            }
            else if (teachers.Contains(teacher))
            {
                teachers.Remove(teacher);
                counter--;
                Console.WriteLine("Successfully revomed!");
            }

        }
        public void Sort()
        {
            var result = from teacher in teachers
                         orderby teacher.Surname, teacher.Name, teacher.Age descending
                         select teacher;
            Console.WriteLine("Sort: ");
            foreach (Teacher u in result)
                 u.GetInfo();
                    
        }
        public void Find(string Surname)
        {
            foreach (Teacher i in teachers)
            {
                if (Surname == i.Surname)
                {
                   
                    i.GetInfo();

                }
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Teacher list: ");
            if (counter == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (Teacher a in teachers)
                {

                    a.GetInfo();
                }
            }
        }

    }
}
