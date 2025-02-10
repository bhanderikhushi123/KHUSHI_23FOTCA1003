using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.Demotest
{

    class Shape
    {

        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        public double Radius;

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }


    class Triangle : Shape
    {
        public double Base;
        public double Height;

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class Program
    {
        static void Main()
        {

            Circle circle = new Circle();
            Console.Write("Enter radius of circle: ");
            circle.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Circle Area: " + circle.CalculateArea());


            Rectangle rectangle = new Rectangle();
            Console.Write("Enter width of rectangle: ");
            rectangle.Width = double.Parse(Console.ReadLine());
            Console.Write("Enter height of rectangle: ");
            rectangle.Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());


            Triangle triangle = new Triangle();
            Console.Write("Enter base of triangle: ");
            triangle.Base = double.Parse(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            triangle.Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
        }
    }
}
