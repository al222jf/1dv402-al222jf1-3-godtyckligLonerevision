using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._3_godtyckligLonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varible
            int numberOfSalaries;
            int salaryAmount;
            
            //User input number of saleries
            
            do
            {
                numberOfSalaries = ReadInt("Ange antal löner att mata in: ");

                if (numberOfSalaries >= 2)
                {
                    ProcessSalaries(numberOfSalaries);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Du måste mata in minst två löner för att kunna göra en beräkning! \n");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n Tryck tanget för ny beräkning - Esc avslutar.\n");
                    Console.ResetColor();
                }





            }
            while (Console.ReadKey(true).Key == ConsoleKey.Escape == false);
            
            //User inputs salaries
        }
        private static void ProcessSalaries(int count)
        {
            //Declare an array that will be as big as the numberOfSalaries
            int[] salaryArray = new int[count];
            double average;
            int difference;

            //Loops out the amount of salaries the user want
            Console.WriteLine();
            for (int i = 0; i < salaryArray.Length; i++)
            {
                while (true)
                {
                    Console.Write("Ange lön nummer {0}: ", i + 1);
                    string salary = Console.ReadLine();
                    
                    try
                    {
                        salaryArray[i] = int.Parse(salary);
                        break;
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Out.WriteLine("\n FEL! {0} kan inte tolkas som ett heltal! \n", salary);
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine();

            // Clone salaryArray to salaryArrayCopy to be able to show the correct output after salaryArray is sorted
            int[] salaryArrayCopy = new int[salaryArray.Length];
            Array.Copy(salaryArray, salaryArrayCopy, salaryArray.Length);

            //Calculates the median
            Console.WriteLine("----------------------------------------");
            Array.Sort(salaryArray);
            int median = salaryArray.Length;

            if (median % 2 == 0)
            {
                int firstMedian = salaryArray[(median / 2 - 1)];
                int secondMedian = salaryArray[(median / 2)];
                Console.WriteLine("Medianlön:{0:c0}", (firstMedian + secondMedian) / 2);
            }
            else
            {
                Console.WriteLine("Medianlön:{0:c0}", salaryArray[median / 2]);
            }

            //Calculate the average
            average = salaryArray.Average();

            Console.WriteLine("Medellön:{0:c0}", average);

            //Calculate the difference between the max and min amount
            difference = salaryArray.Max() - salaryArray.Min();

            Console.WriteLine("Lönespridning:{0:c0}", difference);
            Console.WriteLine("----------------------------------------");
            
            //Write out from array and show the three in a row
            for (int i = 0; i < salaryArray.Length; i++)
            {
                Console.Write("{0}   ", salaryArrayCopy[i]);

                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
        private static int ReadInt(string prompt) 
        {
            string salaries;
            int staticSalaries;

            while (true)
            {
                Console.Write(prompt);
                salaries = Console.ReadLine();
                    
                try
                {
                    staticSalaries = int.Parse(salaries);
                    return staticSalaries;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine("\n FEL! {0} kan inte tolkas som ett heltal! \n", salaries);
                    Console.ResetColor();
                }
            }
        }
    }   
}
