using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Rectangle : IShape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return width * height;
        }

        public double Perimeter()
        {
            return 2 * (width + height);
        }
    }
}
