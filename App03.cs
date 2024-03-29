using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Schema;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Here moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public char GradeA = 'A';
        public char GradeB = 'B';
        public char GradeC = 'C';
        public char GradeD = 'D';
        public char GradeF = 'F';
        public int Mark;
        public int userChoice;
        private bool running = true;
        public double total;

        public const int LowestMark = 0;
        public const int HighestMark = 100;
        public const int Grade_A = 70;
        public const int Grade_B = 60;
        public const int Grade_C = 50;
        public const int Grade_D = 40;
        public const int Grade_F = 0;

        public string[,] studentMarks = new string[,] { { "Susan", "0" }, { "Sade", "0" }, { "Terrance", "0" }, { "Alfie", "0" }, { "Thomas", "0" }, { "Bobby", "0" }, { "Temi", "0" }, { "Raheem", "0" }, { "Romeo", "0" }, { "Darius", "0" } }; //



        private string StudentName;
        private string Grade;



        public void Run()
        {
            while (running)
            {
                Input();
                userDecision();
            }


        }

        public void Input()
        {
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("  Student grades and marks:");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("1. Enter marks");
            Console.WriteLine("2. Find out the grade");
            Console.WriteLine("3. Display marks");
            Console.WriteLine("4. Calculate mean marks");
            Console.WriteLine("5. Highest mark");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Enter number > ");
            userChoice = Convert.ToInt32(Console.ReadLine());
        }

        public void userDecision()
        {
            switch (userChoice)
            {
                case 1:
                    UpdateArray();
                    break;

                case 2:
                    CalculateGrade();
                    break;

                case 3:
                    Output();
                    break;

                case 4:
                    CalculateMean();
                    break;

                case 5:
                    CalculateHighestMark();
                    break;

                case 6:
                    running = false;
                    break;
            }
        }
        public void UpdateArray()
        {
            for (int i = 0; i <= studentMarks.GetLength(0) - 1; i++)
            {
                Console.Write($"Enter {studentMarks[i, 0]}'s mark > ");
                string newStudentMark = Console.ReadLine();
                studentMarks[i, 1] = newStudentMark;
            }
        }
            public void Output()
            {
                for (int i = 0; i < studentMarks.GetLength(0); i++)
                {
                    Console.WriteLine($"{studentMarks[i, 0]}'s mark is {studentMarks[i, 1]}");
                }
            }

        

        public void CalculateGrade()

        {
            for (int i = 0; i < studentMarks.GetLength(0); i++)
            {
                Mark = Convert.ToInt32(studentMarks[i, 1]);
                // to do check, you must get the 2nd value from the 2d array and convert it to an int
                if (Mark >= Grade_A)
                {
                    Console.WriteLine($"{studentMarks[i, 0]} grade is {GradeA}");
                }
                else if (Mark >= Grade_B)
                {
                    Console.WriteLine($"{studentMarks[i, 0]} grade is {GradeB}");
                }
                else if (Mark >= Grade_C)
                {
                    Console.WriteLine($"{studentMarks[i, 0]} grade is {GradeC}");
                }
                else if (Mark >= Grade_D)
                {
                    Console.WriteLine($"{studentMarks[i, 0]} grade is {GradeD}");
                }
                else { Console.WriteLine($"{studentMarks[i, 0]} grade is {GradeF}"); }
            }
        }

        public void CalculateMean()
        {
            for (int i = 0; i <= studentMarks.GetLength(0) - 1; i++)
            {
                string currentStudentMark = studentMarks[i, 1];
                double temp = Convert.ToDouble(currentStudentMark);
                total =+ temp;
            }

            total = total / studentMarks.GetLength(0);
            OutputMean(total);

            
        }

        public void OutputMean(double total)
        {
            Console.WriteLine($"The mean is {total * 10}");
        }

        public void CalculateHighestMark()
        {
            int highestMark = int.MaxValue;
            for (int i = 0; i <= studentMarks.GetLength(0); i++)
            {
                string hereStudentMark = studentMarks[i, 1];
                int temp = Convert.ToInt32(hereStudentMark);
                highestMark = highestMark + temp;

                if (hereStudentMark[i] > highestMark)
                {
                    Console.WriteLine(temp + "" + hereStudentMark);
                }
            }
                
                

            
        }

    }

}
