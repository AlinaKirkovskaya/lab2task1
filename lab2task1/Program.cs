using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Lab2task1";
            Console.Write("Enter the length of the first side of the rectangle: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side of the rectangle: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Area of ​​the rectangle: {rectangle.Area}");
            Console.WriteLine($"Perimeter of a rectangle: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
