using System;
using MindBoxLib;

namespace MindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCircle = CalcArea.Circle(2);
            double areaTriangle = CalcArea.Triangle(5, 5, 5);
            Console.WriteLine(areaCircle);
            Console.WriteLine(areaTriangle);
            Console.ReadKey();
        }
    }
}
