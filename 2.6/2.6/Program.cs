using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter a = new Converter();
            Converter.Bank();

        }
    }

    class Converter
    {
        private static double usd = 26;
        private static double eur = 37;
        private static double pln = 7;
        public static double uah;
        public Converter()
        {
            Console.WriteLine("Введіть суму:");
            uah = Convert.ToDouble(Console.ReadLine());
        }

        static public void Bank()
        {
            double a = uah * usd;
            Console.WriteLine("Долари: ");
            Console.WriteLine(a);
            double b = uah * eur;
            Console.WriteLine("Євро: ");
            Console.WriteLine(b);
            Console.WriteLine("Злоти: ");
            double c = uah * pln;
            Console.WriteLine(c);
        }
    }
}
