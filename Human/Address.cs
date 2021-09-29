using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Address
    {
        private string country;
        private string region;
        private string city;
        private string street;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public void Address1(string Country, string Region, string City, string Street)
        {
            country = Country;
            region = Region;
            city = City;
            street = Street;
        }
        public void GetInfo() { Console.WriteLine($"Страна {Country} Область {Region} Город {City} Улица {Street}"); }

    }
}
