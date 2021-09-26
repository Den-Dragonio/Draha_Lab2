using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2._3
{
    class Program
    {
        static public void Main(string[] args)
        {
            User l = new User();
            User.Show();
            Console.ReadKey();
        }
    }
    class User
    {
        public static string login;
        public static string name;
        public static string surname;
        public static int age;
        private static string date;
        static User()
        {
            Console.WriteLine("Write your Login: ");
            login = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Write your Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Write your Surname: ");
            surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Write your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date: ");
            date = Convert.ToString(Console.ReadLine());
        }
        static public void Show()
        {
            Console.WriteLine("Your login:" + login);
            Console.WriteLine("Your name:" + name);
            Console.WriteLine("Your surname:" + surname);
            Console.WriteLine("Your age:" + age);
            Console.WriteLine("Date: " + date);
        }
    }
}
