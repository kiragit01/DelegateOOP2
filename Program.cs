
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOOP2
{
    class Program
    {
        delegate double Square(double a, double b, double c);
        static void Main()
        {
            Square square;
            square = SquareTriangle;

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь = {square(a, b, c):f2}");

            Console.ReadKey();
        }

        static double SquareTriangle(double a, double b, double c) 
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s; 
        }

    }
}
