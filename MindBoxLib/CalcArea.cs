using System;

namespace MindBoxLib
{
    public class CalcArea
    {
        public static double Circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public static double Triangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
