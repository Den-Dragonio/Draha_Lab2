﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Rectangle
    {
        double side1;
        double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }


        static double AreaCalculator(double a, double b)
        {
            return a * b;
        }
        static double PerimeterCalculator(double a, double b)
        {
            return 2 * (a + b);
        }
        double Area { get; }
        double Perimetr { get; }

        static void Main(string[] args)
        {
            double side1;
            double side2;
            Console.WriteLine("Введіть довжину першої сторони: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть довжину другої сторони: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площа прямокутника: " + Rectangle.AreaCalculator(side1, side2));
            Console.WriteLine("Периметр прямокутника: " + Rectangle.PerimeterCalculator(side1, side2));
            Console.ReadLine();
        }
    }

}


