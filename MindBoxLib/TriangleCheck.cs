using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxLib
{
    public class TriangleCheck
    {
        public static bool IsRight(double a, double b, double c)
        {
            // Данный метод проверяет, является ли треугольник прямоугольным по трем его сторонам, используя теорему Пифагора.
            if ( (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))  ||  (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))  ||  (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
