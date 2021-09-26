using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Address
    {
        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        private int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address Example = new Address();
            Console.WriteLine("Впишіть індекс: ");
            Example.Index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Впишіть країну: ");
            Example.Country = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Впишіть місто: ");
            Example.City = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Впишіть вулицю: ");
            Example.Street = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Впишіть дім: ");
            Example.House = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Впишіть квартиру: ");
            Example.Apartment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Example.Index);
            Console.WriteLine(Example.Country);
            Console.WriteLine(Example.City);
            Console.WriteLine(Example.Street);
            Console.WriteLine(Example.House);
            Console.WriteLine(Example.Apartment);
            Console.ReadLine();
            }
        }
    
}


