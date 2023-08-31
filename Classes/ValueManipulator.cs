namespace GeometryGuru.Classes;

public class ValueManipulator
{
    public static void ShowMenu() =>
    Console.Write("1.Enter the application\n2.Exit\nChoice: ");

    public static double GetUserValueByMassage(string text)
    {
        Console.Write(text);
        return Convert.ToDouble(Console.ReadLine());
    }
    
    public static string AppLogin()
    {
        Console.Write("\nLaunch the application? yes or no\nChoice: ");
        string choice = Console.ReadLine()!;
        return choice;
    }
    
}