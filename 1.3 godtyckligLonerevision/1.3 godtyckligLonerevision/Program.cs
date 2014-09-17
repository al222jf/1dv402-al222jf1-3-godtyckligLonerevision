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
                Console.WriteLine("den är mer än två!");
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

            //Write out from array
            //for (int i = count; i > 0; i--)
            //{
            //    Console.WriteLine(salaryArray[i]);
            //}
        }
        private static int ReadInt(string prompt) 
        {
            Console.Write(prompt);
            int staticSalaries = int.Parse(Console.ReadLine());
                return staticSalaries;
        }
    }   
}
