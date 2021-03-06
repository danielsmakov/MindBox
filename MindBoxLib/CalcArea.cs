using System;

namespace MindBoxLib
{
    // Это класс, содержащий методы для расчета площадей круга и произвольного треугольника
    public class CalcArea
    {
        public static double Circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public static double Triangle(double a, double b, double c)
        {
            // Расчет площади произвольного треугольника по формуле Герона
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        /*
        SQL запрос из второго задания находится здесь:

        select product.product_name, category.category_name
        from product
        left join category
        on product.category_id = category.category_id;

         */
    }
}
