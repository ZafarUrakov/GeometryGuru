using System;

namespace GeometryGuru
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Want to calculate the area of a circle , square or a tringle?
                So you are in the right place!");

            Console.Write("\nEnter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine()!);

            const double PI = 3.14;

            Console.WriteLine("\n...\n");

            Console.WriteLine("Couting is goig on ... ");
            Console.WriteLine($"{PI} * ({radius} * {radius}) = ... ???\n");
            double radiusSquared = radius * radius;
            Console.WriteLine($"Area = " + radiusSquared * PI); 

        }
    }
}