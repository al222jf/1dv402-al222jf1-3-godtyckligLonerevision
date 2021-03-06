﻿using System;
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
            
            //do while loop to be able to press escape or any key if the want to end or countinue the program
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
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
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
                salaryArray[i] = ReadInt(String.Format("Ange lön nummer {0}: ", i + 1));
            }
            Console.WriteLine();

            // Clone salaryArray to salaryArrayCopy to be able to show the correct order of the array after salaryArray is sorted
            int[] salaryArrayCopy = new int[salaryArray.Length];
            Array.Copy(salaryArray, salaryArrayCopy, salaryArray.Length);

            //Calculates the median
            Console.WriteLine("----------------------------------------");
            Array.Sort(salaryArray);
            

            if (salaryArray.Length % 2 == 0)
            {
                int firstMedian = salaryArray[(salaryArray.Length / 2 - 1)];
                int secondMedian = salaryArray[(salaryArray.Length / 2)];
                Console.WriteLine("{0,-15}:{1,15:c0}","Medianlön", (firstMedian + secondMedian) / 2);
            }
            else
            {
                Console.WriteLine("{0,-15}:{1,15:c0}","Medianlön", salaryArray[(salaryArray.Length / 2)]);
            }

            //Calculate the average

            Console.WriteLine("{0,-15}:{1,15:c0}","Medellön", salaryArray.Average());

            //Calculate the difference between the max and min amount

            Console.WriteLine("{0,-15}:{1,15:c0}", "Lönespridning", salaryArray.Max() - salaryArray.Min());
            Console.WriteLine("----------------------------------------");
            
            //Write out from array and show the three in a row
            for (int i = 0; i < salaryArray.Length; i++)
            {
                Console.Write("{0,10}", salaryArrayCopy[i]);

                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            //Display a text message asking if the user wants to do a new calculation or end
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n Tryck tanget för ny beräkning - Esc avslutar.\n");
            Console.ResetColor();
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
