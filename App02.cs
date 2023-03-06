using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        private double kilograms;
        private double metres;
        private double BMIresult;

        private double height;
        private double weight;

        private string weightClass;
        private string bmiStatementObeseIII;
        private string bmiStatementOverweight;


        public void Run()
        {
            BodyMassInput();
            Calculation();
            BodyMassResult();  
        }


        private void BodyMassInput()
        {
            Console.WriteLine("This is a BMI calculator");
            Console.WriteLine("Enter height in meters");
            string temp = Console.ReadLine();
            height = Convert.ToDouble(temp);
            Console.WriteLine("Enter weight in kilograms");
            weight = Convert.ToDouble(Console.ReadLine());

        }

        private void Calculation()
        {
            BMIresult = weight / (height * height);
            if (BMIresult < 18.50)
            {
                weightClass = "Underweight";
            }
            else if (BMIresult > 18.50 && BMIresult <= 24.90)
            {
                weightClass = "Normal";
                
            }
            else if (BMIresult > 25.00 && BMIresult <= 29.00)
            {
                weightClass = "Overweight";
                bmiStatementOverweight = "This means you have a body mass Index of between 25 and 29kg/m2";
                
            }
            else if (BMIresult > 30.00 && BMIresult <= 34.90)
            {
                weightClass = "Obese Class I";
            }
            else if (BMIresult > 34.90 && BMIresult <= 39.90)
            {
                weightClass = "Obese Class II";
                
            }
            else if (BMIresult >= 40.00)
            {
                weightClass = "Obese Class III";
                bmiStatementObeseIII = "Some groups, especially Black and ethnic minority groups have a higher likelihood of becoming overweight due to a myriad of factors including socioeconomic status and diet ";
            }

        
        } 

        private void BodyMassResult()
        {
            Console.WriteLine();
            Console.WriteLine(weightClass);
            Console.WriteLine(bmiStatementObeseIII);
            
        }

    }


       
 }
    