﻿using System;

namespace triangle_information_console
{
    class Program
    {
        public static decimal sideAInput { get; private set; } = 0;
        public static decimal sideBInput { get; private set; } = 0;
        public static decimal sideCInput { get; private set; } = 0;

        static void Main(string[] args)
        {
            GetAppInfo();

            while (true)
            {
                while(sideAInput == 0) { 
                    SideInput("A");
                }
                while (sideBInput == 0)
                {
                    SideInput("B");
                }
                while (sideCInput == 0)
                {
                    SideInput("C");
                }

                CheckTriangle();

                Console.WriteLine("Press the Y key to enter information about another triangle.");
                string anotherTriangle = Console.ReadLine().ToUpper();

                if (anotherTriangle == "Y")
                {
                    sideAInput = 0;
                    sideBInput = 0;
                    sideCInput = 0;
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Triangle Information in the console";
            string appVersion = "1.0.0";
            string appAuthor = "Tyler Casperson";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine();
            Console.WriteLine("Enter a number (natural or decimal) for each side. As soon as all three fields have valid data in them, calculations will run to let you know information about the triangle.");
            Console.WriteLine();
            Console.ResetColor();
        }

        static void SideInput(string side)
        {
            decimal length = 0;
            

            while (length == 0)
            {
                Console.WriteLine("What is the length of side " + side + "?");
                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out length))
                {
                    PrintColorMessage(ConsoleColor.Red, "Please enter an actual number.");
                    continue; 
                }
                length = decimal.Parse(input);

                switch (side)
                {
                    case "A":
                        sideAInput = length;
                        return;
                    case "B":
                        sideBInput = length;
                        return;
                    case "C":
                        sideCInput = length;
                        return;
                }
            }
        }

        static void CheckTriangle()
        {
            string triangle;

            if(sideAInput == sideBInput && sideAInput == sideCInput)
            {
                triangle = "Equilateral";
            }
            else if(sideAInput != sideBInput && sideAInput != sideCInput)
            {
                triangle = "Scaleneal";
            }
            else
            {
                triangle = "Isosceles";
            }

            if(sideAInput + sideBInput >= sideCInput)
            {
                if(sideBInput + sideCInput >= sideAInput)
                {
                    if(sideCInput + sideAInput >= sideBInput)
                    {
                        Console.WriteLine("These side lengths produce a valid " + triangle + " triangle.");
                        return;
                    }
                }
            }
            Console.WriteLine("These sides do not produce a valid triangle.");
        }

        static void PrintColorMessage(ConsoleColor color, string message )
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}
