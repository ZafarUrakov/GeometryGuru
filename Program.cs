using System;
using System.Diagnostics;
using GeometryGuru.Classes;

namespace GeometryGuru
{
    class Program
    {
        static void Main()
        {
            string backToMenu;
            var report = new Report();
            do
            {
                Console.Clear();
                double userChoice = ValueManipulator.
                    GetUserValueByMassage("1.Enter the application\n2.Exit\nChoice: ");

                switch (userChoice)
                {
                    case 1:
                        var figureArea = new FigureArea();
                        figureArea.security();
                        break;
                    case 2:
                        report.Exit();
                        break;
                    default:
                        report.DefaultProgress();
                        break;
                }
                
                backToMenu = ValueManipulator.AppLogin();
            } while (backToMenu == "yes");
        }
    }    
}
