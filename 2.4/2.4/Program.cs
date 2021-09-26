using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Point
    {
        public int Coordinate_X { get; } 
        public int Coordinate_Y { get; }
        public string Name { get; }

        public Point(int x, int y, string name)
        {
            Coordinate_X = x;
            Coordinate_Y = y;
            Name = name; 
        }
    }
    class Figure
    {
        public Point[] points { get; } 
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }
        public double LengthSide(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.Coordinate_X - point2.Coordinate_X, 2) + Math.Pow(point1.Coordinate_Y - point2.Coordinate_Y, 2));
        }
        public void PerimetrCalculator()
        {
            double Perimetr = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                if (i == points.Length -1)
                {
                    Perimetr += LengthSide(points[i], points[0]);
                }
                else
                {
                    Perimetr += LengthSide(points[i], points[i +1]);
                }
            }
            Console.WriteLine("Perimetr = " + Perimetr);
        } 
        public void GetName()
        {
            string name = "";
            for (int i = 0; i < points.Length - 1; i++)
            {
                name += points[i].Name;
            }
            Console.WriteLine("Name = " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(6, 6, "6"), new Point(7, 7, "7"), new Point(12, 7, "8"), new Point(4, 5, "4"), new Point(5, 5, "4"));
            figure.GetName();
            figure.PerimetrCalculator();

            Console.ReadKey();
        }
    }
}
