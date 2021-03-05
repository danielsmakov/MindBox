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
            bool isRight1 = TriangleCheck.IsRight(3, 5, 4);
            bool isRight2 = TriangleCheck.IsRight(4, 5, 4);
            Console.WriteLine(areaCircle);
            Console.WriteLine(areaTriangle);
            Console.WriteLine(isRight1);
            Console.WriteLine(isRight2);
            Console.ReadKey();
        }
    }
}
