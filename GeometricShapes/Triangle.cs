using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Triangle : IDrawable
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException(
                    "Введено некорректное значение: стороны треугольника должны быть больше нуля."
                );
            }

            if (sideA >= sideB + sideC ||
                sideB >= sideA + sideC ||
                sideC >= sideA + sideB)
            {
                throw new ArgumentException(
                    "Введено некорректное значение: одна сторона должна быть меньше суммы двух других."
                );
            }

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double Area()
        {
            double halfPerimeter = Perimeter() / 2;

            return Math.Sqrt(
                halfPerimeter *
                (halfPerimeter - sideA) *
                (halfPerimeter - sideB) *
                (halfPerimeter - sideC)
            );
        }

        public double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public string Draw()
        {
            return "    ▲\n" +
                   "   ▲▲▲\n" +
                   "  ▲▲▲▲▲\n" +
                   " ▲▲▲▲▲▲▲";
        }
    }
}