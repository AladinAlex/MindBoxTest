using System;
using Shape;
using Shape.Figure;

namespace test
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Площадь круга: " + Shape.Shape.FindArea(5));

            Console.WriteLine("Площадь треугольника: " + Shape.Shape.FindArea(98, 76, 132));

            Console.WriteLine("Треугольник прямоугольный: " + Shape.Shape.IsRightTriangle(98, 76, 132));

            var circle = new Circle(5.2);
            Console.WriteLine("Площадь круга: " + circle.FindArea());

            var triangle = new Triangle(5.2, 6.8, 9.1);
            Console.WriteLine("Площадь треугольника: " + triangle.FindArea());
            Console.WriteLine("Треугольник прямоугольный: " + triangle.IsRightTriangle());

            Console.ReadKey();
        }
    }
}

