using System;

namespace GeometryGuru
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Want to calculate the area of a circle , square or a tringle?
                So you are in the right place!");

            Console.WriteLine(@"What geometric figure do you want to find the area of ?:
            1.Circle
            2.Tringle
            3.Square");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.Write("\nEnter the radius of the circle: ");
                var radius = double.Parse(Console.ReadLine()!);

                const double PI = 3.14;

                Console.WriteLine("\n...\n");

                Console.WriteLine("Couting is goig on ... ");
                Console.WriteLine($"{PI} * ({radius} * {radius}) = ... ???\n");
                var radiusSquared = radius * radius;
                Console.WriteLine($"Area = " + radiusSquared * PI); 
            }   
            else if(choice == 2)
            {
                 Console.WriteLine("\nEnter the height and side of the triagle.\n");

                Console.Write("Height:");
                double heightOfTriagle = Convert.ToDouble(Console.ReadLine());
                Console.Write("Side:");
                double sideOfTriagle = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n...\n");

                double areaOfTriagle = sideOfTriagle * (heightOfTriagle * heightOfTriagle);

                Console.WriteLine($"Area of a triagle : {areaOfTriagle}");
            }
            else if(choice == 3)
            {
                Console.WriteLine("\nEnter the side of the square.\n");

                Console.Write("Square: ");
                double sideOfSquare = Convert.ToDouble(Console.ReadLine());

                double areaOfSquare = sideOfSquare * sideOfSquare;

                Console.WriteLine($"Area of a square : {areaOfSquare}");
            }
            else 
                Console.WriteLine("There is no such choice , try again by entering \"dotnet run\" ");
        }
    }
}