using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Aaron                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            // DistanceConverter converter = new DistanceConverter();
            //converter.Run();
            Console.WriteLine("Which app would you like to use?");
            Console.WriteLine();
            Console.WriteLine("Press 1 for the Distance converter");
            Console.WriteLine("Press 2 for the BMI calculator");
            string input = Console.ReadLine();
            int choiceInput = 0;
            try
            {
                choiceInput = Convert.ToInt32(input);
                if (choiceInput == 1)
                {
                    DistanceConverter converter = new DistanceConverter();
                    converter.Run();
                }
                else if (choiceInput == 2)
                {

                    BMI bodyMass = new BMI();
                    bodyMass.Run();
                }
                else
                {
                    Console.WriteLine("Invalid input, please pick one of the given options");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
