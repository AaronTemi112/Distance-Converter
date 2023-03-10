using ConsoleAppProject.App02;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {

        public double miles;
        public double feet;
        public const int FEET_TO_MILES = 5280;
        public const double MILES_TO_METRES = 1609.344;
        public const int METRES_TO_CENTIMETRES = 1000;
        public const double MILES_TO_FEET = 0.000189;
        public double kilograms;
        public double metres;
        public double BMIresult;

        public string userInput; 
        public double inputValue;
        public double result;

        public void Run()
        {
        //     // input

        //     //Console.WriteLine("Would you like to convert from miles to feet?");
        //     Console.WriteLine("Which units would you like to convert to? Enter a number here:");

            
        //     //Console.WriteLine("Would you like to convert from feet to miles?");
        //     userInput = Console.ReadLine();
        //     miles = Convert.ToInt32(userInput);
        //     //int choice = Convert.ToInt32(Console.ReadLine());
        //     //Console.WriteLine(miles)

        //     //Method
        //     //const int FEET_TO_INCHES = 52800; 
        //     feet = miles * FEET_TO_MILES;
        

        //     //output

        // Console.WriteLine(miles + " miles is " + feet + " feet");

        UserInput();
        ConvertDistance();
        UserOutput();
        

        }

        public void ConvertFeetToMiles()
        {
            miles = feet / FEET_TO_MILES;
        }

        public void ConvertMilesToFeet()
        {
            miles = miles / FEET_TO_MILES;
        }


        public void ConvertMilesToMetres()
        {
            miles = miles / MILES_TO_METRES;
        }
        public void UserInput()
        {
            Console.WriteLine("Which units would you like to convert to and from?");
            Console.WriteLine();
            Console.WriteLine("1. Miles to feet?");
            Console.WriteLine("2. Feet to miles?");
            Console.WriteLine("3. Metres to centimetres?");
            Console.WriteLine("4. Miles to metres?");
            Console.WriteLine("Enter a number here: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter number to convert:");
            inputValue = Convert.ToDouble(Console.ReadLine());
            
        }
        public void ConvertDistance()
        {
            switch(userInput)
            {
                // miles to feet 
                case "1": 
                    result =  inputValue * FEET_TO_MILES;
                    
                    //Console.WriteLine(" miles is " + feet + " feet");
                    
                break;

                // feet to miles
                case "2":
                    result = inputValue * MILES_TO_FEET;

                    // Console.WriteLine(" feet is " + miles + " miles");
            
                break;

                // metres to centimetres
                case "3":

                    result = inputValue * METRES_TO_CENTIMETRES;

                break;

                //miles to metres
                case "4":

                    result = inputValue * MILES_TO_METRES;

                break;
            }
        }

        // private void OutputValue()
        // {
        //     Console.WriteLine($"{input} miles is {miles}")
        // }

        public void UserOutput()
        {
            switch(userInput)
            {
                case "1":
                    Console.WriteLine($"{inputValue} miles is  {result} feet ");
                break;

                case "2":
                    Console.WriteLine($"{inputValue} feet is  {result} miles ");
                break;

                case "3":
                    Console.WriteLine($"{inputValue} metres is {result} centimetres ");
                break;

                case "4":
                    Console.WriteLine($"{inputValue} miles is {result} metres ");
                break;
            }

            Console.WriteLine();
        }
    
        
      




        }
    }


