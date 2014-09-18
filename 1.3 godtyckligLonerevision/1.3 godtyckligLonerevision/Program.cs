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
            numberOfSalaries = ReadInt("Ange antal löner att mata in: ");
            if (numberOfSalaries >= 2)
            {
                ProcessSalaries(numberOfSalaries);
            }
            else
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tryck tanget för ny beräkning - Esc avslutar.");
                Console.ResetColor();

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
            
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
            for (int i = 0; i < count; i++)
            {
                Console.Write("Ange lön nummer {0}: ", i + 1);
                salaryArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            
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
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}   ", salaryArray[i]);

                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
        private static int ReadInt(string prompt) 
        {
            int staticSalaries;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    staticSalaries = int.Parse(Console.ReadLine());
                    
                    return staticSalaries;
                }
                catch
                {
                    
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FelFelFel {0}", staticSalaries);
                    Console.ResetColor();
                }
            }
        }
    }   
}
