using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Employee
    {
        private static string name;
        private static string surname;
        public static double k = 1;
        public static double kk = 1;
        public Employee()
        {
            Console.WriteLine("Впишите ваше имя: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Впишите вашу фамилию: ");
            surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Назовите вашу должность: ");
            Console.WriteLine("(Подчиненный = 1) ");
            Console.WriteLine("(Начальник отдела = 2) ");
            Console.WriteLine("(Директор = 3): ");
            int job = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Назовите ваш стаж работы: ");
            double years = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Назовите вашу зарплату: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (3 < years && years< 10)
            {
                k = 0.1;
            }
            if (10 < years && years< 20)
            {
                k = 0.2;
            }
            if (years > 20)
            {
                k = 0.3;
            }
            if (job == 1)
            {
                kk = 0.1;
            }
            if (job == 2)
            {
                kk = 0.2;
            }
            if (job == 3)
            {
                kk = 0.3;
            }
            Console.WriteLine("Ваш оклад составляет: " + Oklad(salary));
            Console.WriteLine("Ваш налоговый збор составляет: " + Nalog(salary, k, kk));
        }
        
        public static double Oklad(double a)
        {
            return a / 0.805;
        }
        public static double Nalog(double a, double b, double c)
        {
            double r;
            r = (((a / 0.805) + ((a / 0.805) * b) + ((a / 0.805) * c)) * 0.195);
            return r;
        }
    }


    class Prgram
    {

        static void Main(string[] args)
        {
            Employee n = new Employee();

            Console.ReadKey();
        }
    }
}
