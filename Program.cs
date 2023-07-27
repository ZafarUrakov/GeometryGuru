using System;

namespace GeometryGuru
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.WriteLine(@"
                1.Enter the offer
                2.Exit");
                int usetChoice = Convert.ToInt32(Console.ReadLine()!);
                if(usetChoice == 1)
                {
                    Console.WriteLine(@"Want to calculate the area of a circle , square or a tringle?
                        So you are in the right place!");

                    Console.WriteLine("O seeks the one who has my help! How old are you?");
                    Console.Write("Old: ");
                    int old = Convert.ToInt32(Console.ReadLine()!);
                    if(old > 18)
                    {
                        Console.WriteLine("\nYou are too old for these tasks , think for yourelf!");
                    }
                    else 
                    {

                        Console.WriteLine(@"What geometric figure do you want to find the area of ?:
                        1.Circle
                        2.Tringle
                        3.Square");
                        Console.Write("Choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch(choice)
                        {
                            case 1:
                            Console.Write("\nEnter the radius of the circle: ");
                            var radius = double.Parse(Console.ReadLine()!);

                            const double PI = 3.14;

                            Console.WriteLine("\n...\n");

                            Console.WriteLine("Couting is goig on ... ");
                            Console.WriteLine($"{PI} * ({radius} * {radius}) = ... ???\n");
                            var radiusSquared = radius * radius;
                            Console.WriteLine($"Area = " + radiusSquared * PI); 
                            break;

                            case 2:
                            Console.WriteLine("\nEnter the height and side of the triagle.\n");

                            Console.Write("Height:");
                            double heightOfTriagle = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Side:");
                            double sideOfTriagle = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\n...\n");

                            double areaOfTriagle = sideOfTriagle * (heightOfTriagle * heightOfTriagle);

                            Console.WriteLine($"Area of a triagle : {areaOfTriagle}");
                            break;

                            case 3:
                            Console.WriteLine("\nEnter the side of the square.\n");

                            Console.Write("Square: ");
                            double sideOfSquare = Convert.ToDouble(Console.ReadLine());

                            double areaOfSquare = sideOfSquare * sideOfSquare;

                            Console.WriteLine($"Area of a square : {areaOfSquare}");
                            break;
                        
                        default:
                            Console.WriteLine("There is no such choice , try again by entering \"dotnet run\" ");
                            break;
                        }
                    }
                }
                else
                    break;    
            }
            while(true);    
        }    
    }
}