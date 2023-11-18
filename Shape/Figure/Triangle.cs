using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Figure
{
    public class Triangle : IArea
    {
        private double _a;
        private double _b;
        private double _c;
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Площадь тругольника
        /// </summary>
        /// <returns></returns>
        public double FindArea()
        {
            if (!isRight())
                return 0;

            double p = (_a + _b + _c) / 2;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <summary>
        /// Проверка на правильность треугольника
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            if (!isRight())
                return false;

            return Math.Pow(_a, 2) == Math.Pow(_b, 2) + Math.Pow(_c, 2)
            || Math.Pow(_b, 2) == Math.Pow(_a, 2) + Math.Pow(_c, 2)
            || Math.Pow(_c, 2) == Math.Pow(_a, 2) + Math.Pow(_b, 2);
        }

        /// <summary>
        /// Проверка может ли существовать треугольник с введенными сторонами
        /// </summary>
        /// <returns></returns>
        private bool isRight()
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
                return false;

            if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
                return false;

            return true;
        }

    }
}
