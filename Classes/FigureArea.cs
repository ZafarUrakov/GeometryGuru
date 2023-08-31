using GeometryGuru.Interfaces;

namespace GeometryGuru.Classes;

public class FigureArea : IFigureArea
{
    public int Old { get; set; }
    public double Radius { get; set; }
    public double Height { get; set; }
    public double Side { get; set; }
    public double Square { get; set; }
    
    public void security()
    {
        Console.Clear();
        Console.WriteLine("O seeks the one who has my help! How old are you?");
        Console.WriteLine("Old: ");
        if (Old > 18)
            Console.WriteLine("\nYou are too old for these tasks , think for yourself!");
        else
            AreaCalculation();
    }

    public void AreaCalculation()
    {
        Console.Clear();
        var report = new Report();
        Console.WriteLine("What geometric figure do you want to find the area of ?");
        Console.WriteLine("1.Circle");
        Console.WriteLine("2.Triangle");
        Console.WriteLine("3.Square");
        double choice = ValueManipulator.GetUserValueByMassage("Choice: ");
        switch (choice)
        {
            case 1:
                Console.Clear();
                Radius = ValueManipulator.GetUserValueByMassage("Enter the radius of the circle: ");
                const double PI = 3.14;
                report.ResultProgress();
                double radiusSquared = Radius * Radius;
                Console.WriteLine($"Area = " + radiusSquared * PI);
                break;

            case 2:
                Console.Clear();
                Height =
                    ValueManipulator.GetUserValueByMassage("Enter the height and side of the triangle.\nHeight:");
                Side = ValueManipulator.GetUserValueByMassage("Side:");
                report.ResultProgress();
                double areaOfTriangle = Side * (Height * Height);
                Console.WriteLine($"Area of a triangle : {areaOfTriangle}");
                break;

            case 3:
                Console.Clear();
                Square =
                    ValueManipulator.GetUserValueByMassage("Enter the side of the square.\nSquare: ");
                double areaOfSquare = Square * Square;
                Console.WriteLine($"Area of a square : {areaOfSquare}");
                break;

            default:
                report.DefaultProgress();
                break;
        }
    }
}