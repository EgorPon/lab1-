using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Student : Human
    {
        private marks rating;
        private int averagemark;
        private int[] mass;

        public Student(string Name, string Surname, int Age, string Country, string Region, string City, string Street) : base(Name, Surname, Age, Country, Region, City, Street)
        {


            mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                mass[i] = rnd.Next(1, 6);

            }

            //*******
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += mass[i];
            }
            averagemark = sum / 5;

            //*******

            switch (averagemark)
            {
                case 1:
                    rating = marks.bad;
                    break;
                case 2:
                    rating = marks.poor;
                    break;
                case 3:
                    rating = marks.fair;
                    break;
                case 4:
                    rating = marks.good;
                    break;
                case 5:
                    rating = marks.excellent;
                    break;

            }

        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"averagemark: {averagemark} rating: {rating}");
        }


    }



}


