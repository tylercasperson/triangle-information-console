using System;

namespace triangle_information_console
{
    class Program
    {
        static void Main(string[] args)
        { 
            string appName = "Triangle Information in the console";
            string appVersion = "1.0.0";
            string appAuthor = "Tyler Casperson";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            string question = "What is the length of side ";

            int sideAInput = 0;
            int sideBInput = 0;
            int sideCInput = 0;


            Console.WriteLine(question + "A?");
            string sideA = Console.ReadLine();

            sideAInput = Int32.Parse(sideA);

            Console.WriteLine(question + "B?");
            string sideB = Console.ReadLine();
            sideBInput = Int32.Parse(sideB);

            Console.WriteLine(question + "C?");
            string sideC = Console.ReadLine();
            sideCInput = Int32.Parse(sideC);


            Console.WriteLine("Hello World!");
        }
    }
}
