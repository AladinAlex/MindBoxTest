using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Figure
{
    public class Circle : IArea
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns></returns>
        public double FindArea()
        {
            if (_radius <= 0)
                return 0;

            return Math.PI * _radius * _radius;
        }
    }
}
