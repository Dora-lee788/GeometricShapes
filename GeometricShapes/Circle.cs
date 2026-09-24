using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Circle : IShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
