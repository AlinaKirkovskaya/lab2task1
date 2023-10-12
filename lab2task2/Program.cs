using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(0, 4, "B");
            Point point3 = new Point(3, 0, "C");

            Figure triangle = new Figure(point1, point2, point3);
            triangle.CalculatePerimeter();

            Point point4 = new Point(3, 4, "D");
            Figure quadrilateral = new Figure(point1, point2, point3, point4);
            quadrilateral.CalculatePerimeter();

            Point point5 = new Point(4, 4, "E");
            Figure pentagon = new Figure(point1, point2, point3, point4, point5);
            pentagon.CalculatePerimeter();

            Console.ReadKey();
        }
    }
}
