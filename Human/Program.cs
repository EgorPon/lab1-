using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            Student person = new Student("Misha", "Hohol", 18, "Ukraine", "Kievskaya", "Kiev", "Grushevskogo");
            Student person1 = new Student("Grisha", "Zabugrovich", 21, "Ukraine", "Oddeskaya", "Odessa", "Kanatna");
            Student person2 = new Student("Kolya", "Vodniy", 19, "Ukraine", "Lvivska", "Lviv", "Maydanna");
            Student person3 = new Student("Maxim", "Chornozub", 25, "Ukraine", "Nikolaevskaya", "Nikolaev", "Admirala Makarova");
            Teacher teacher1 = new Teacher("Vitaliy", "Tsal", 30, "Ukraine", "Vinnitskaya", "Vinnitsa", "Ratushnaya");
            Teacher teacher2 = new Teacher("Tolya", "Azot", 78, "Ukraine", "Donetskaya", "Donetsk", "Debal`cevo");

            person.GetInfo();
            person2.GetInfo();
            teacher1.GetInfo();
            teacher1.Add(person2);

            teacher1.StudentInfo();
            teacher1.Remove(person2);
            teacher1.GetInfo();
            teacher1.Remove(person2);


            Console.ForegroundColor = ConsoleColor.White;
            Teacherlist list = new Teacherlist();
            list.Add(teacher1);
            list.Add(teacher2);
            list.GetInfo();
            list.Remove(teacher1) ;
            list.Remove(teacher2);
            list.GetInfo();
            list.Remove(teacher1);

        }
    }
}