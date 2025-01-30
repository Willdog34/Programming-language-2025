using System;

namespace GeometryCalculatorApp
{
    class GeometryCalculator
    {
        /// <summary>
        /// Calculates the area of a rectangle.
        /// If length and width are equal, it treats the shape as a square.
        /// </summary>
        public static double CalculateRectangleArea(double length, double width)
        {
            return (length == width) ? Math.Pow(length, 2) : length * width;
        }

        /// <summary>
        /// Calculates the area of a circle given its radius.
        /// </summary>
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculates the area of a triangle given its base and height.
        /// </summary>
        public static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static void Main()
        {
            Console.WriteLine("Geometry Area Calculator");
            Console.WriteLine("------------------------");

            // Rectangle
            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Rectangle Area: {CalculateRectangleArea(length, width)}\n");

            // Circle
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Circle Area: {CalculateCircleArea(radius):F2}\n");

            // Triangle
            Console.Write("Enter base of triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Triangle Area: {CalculateTriangleArea(baseLength, height)}\n");
        }
    }
}
