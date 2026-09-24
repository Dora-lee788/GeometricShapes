using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricShapes;

namespace GeometricShapes
{
   
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            List<IShape> shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 6)
            };

            try
            {
                shapes.Add(new Triangle(3, 4, 5));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("Геометрические фигуры");
            Console.WriteLine();

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Фигура: {shape.GetType().Name}");
                Console.WriteLine($"Площадь: {shape.Area():F2}");
                Console.WriteLine($"Периметр: {shape.Perimeter():F2}");

                if (shape is IDrawable drawable)
                {
                    Console.WriteLine("Рисунок:");
                    Console.WriteLine(drawable.Draw());
                }

                Console.WriteLine();
            }
        }
    }
}