using System;


namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {



            Student person = new Student("Misha", "Hohol", 18, "Ukraine", "Kievskaya", "Kiev", "Grushevskogo");
            Student person1 = new Student("Grisha", "Zabugrovich", 21, "Ukraine", "Oddeskaya", "Odessa", "Kanatna");
            Student person2 = new Student("Kolya", "Vodniy", 19, "Ukraine", "Lvivska", "Lviv", "Maydanna");
            Student person3 = new Student("Maxim", "Chornozub", 25, "Ukraine", "Nikolaevskaya", "Nikolaev", "Admirala Makarova");
            Teacher teacher1 = new Teacher("Vitaliy", "Gromyako", 30, "Ukraine", "Vinnitskaya", "Vinnitsa", "Cosmonauts Avenue");
            Teacher teacher2 = new Teacher("Tolya", "Got", 78, "Ukraine", "Donetskaya", "Donetsk", "Debal`cevo");

       
            Teacherlist list = new Teacherlist();
         
            Console.WriteLine("1.Student information" +
                              "\n2.Teacher information" +
                              "\n3.Show list of teacher`s students" +
                              "\n4.Add student to the teacher`s list" +
                              "\n5.Remove student to the teacher`s list" +
                              "\n6.Show list of teachers" +
                              "\n7.Add teacher to the list" +
                              "\n8.Remove teacher to the list" +
                              "\n9.Sort the list by surname" +
                              "\n10.Search for a teacher in the list by surname" +
                              "\nif you want to back,enter 0"
                                        );
            while (true)
            {
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        person.GetInfo();
                        person1.GetInfo();
                        person2.GetInfo();
                        person3.GetInfo();
                        break;
                    case "2":
                        teacher1.GetInfo();
                        teacher2.GetInfo();
                        break;
                    case "3":
                        Console.WriteLine("Choose teacher 1 or 2");
                        string b = Console.ReadLine();
                        switch (b)
                        {
                            case "1":
                                teacher1.GetInfo();
                                teacher1.StudentInfo();
                                break;
                            case "2":
                                teacher2.GetInfo();
                                teacher2.StudentInfo();
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Choose teacher 1 or 2");
                        string c = Console.ReadLine();
                        switch (c)
                        {
                            case "1":
                                teacher1.GetInfo();
                                string l = Console.ReadLine();
                                switch (l)
                                {
                                    case "1": teacher1.Add(person); break;
                                    case "2": teacher1.Add(person1); break;
                                    case "3": teacher1.Add(person2); break;
                                    case "4": teacher1.Add(person3); break;
                                    case "0": break;
                                }
                                break;
                           
                            case "2":
                                teacher2.GetInfo();
                                string k = Console.ReadLine();
                                switch (k)
                                {
                                    case "1": teacher2.Add(person); break;
                                    case "2": teacher2.Add(person1); break;
                                    case "3": teacher2.Add(person2); break;
                                    case "4": teacher2.Add(person3); break;
                                    case "0": break;
                                }
                            
                                break;
                            case "0": break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Choose teacher 1 or 2");
                        string f = Console.ReadLine();
                        switch (f)
                        {
                            case "1":
                                teacher1.GetInfo();
                                string u = Console.ReadLine();
                                switch (u)
                                {
                                    case "1": teacher1.Remove(person); break;
                                    case "2": teacher1.Remove(person1); break;
                                    case "3": teacher1.Remove(person2); break;
                                    case "4": teacher1.Remove(person3); break;
                                    case "0": break;
                                }
                                break;

                            case "2":
                                teacher2.GetInfo();
                                string j = Console.ReadLine();
                                switch (j)
                                {
                                    case "1": teacher2.Remove(person); break;
                                    case "2": teacher2.Remove(person1); break;
                                    case "3": teacher2.Remove(person2); break;
                                    case "4": teacher2.Remove(person3); break;
                                    case "0": break;
                                }

                                break;
                            case "0": break;
                        }
                        break;
                    case "6":
                        list.GetInfo();
                        break;
                    case "7":
                        Console.WriteLine("Choose teacher who you want to add:1 or 2");
                        string d = Console.ReadLine();
                        if (d == "1") { list.Add(teacher1); }
                        if (d == "2") { list.Add(teacher2); }
                        break;
                    case "8":
                        Console.WriteLine("Choose teacher who you want to add:1 or 2");
                        string e = Console.ReadLine();
                        if (e == "1") { list.Remove(teacher1); }
                        if (e == "2") { list.Remove(teacher2); }
                        break;
                    case "9":
                        list.Sort();
                        break;
                    case "10":
                        string g = Console.ReadLine();
                        list.Find(g);
                        break;
                  
                }

            }
        }
    }
}