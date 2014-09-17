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
            int[] salaryArray = new int[count];

            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Ange lön nummer {0}: ", i + 1);
                salaryArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Array.Sort(salaryArray);
            int median = salaryArray.Length;

            if (median % 2 == 0)
            {
                int firstMedian = salaryArray[(median / 2 - 1)];
                int secondMedian = salaryArray[(median / 2)];
                Console.WriteLine((firstMedian + secondMedian) / 2);
            }
            else
            {
                Console.WriteLine(salaryArray[median / 2]);
            }
        }
        private static int ReadInt(string prompt) 
        {
            Console.Write(prompt);
            int staticSalaries = int.Parse(Console.ReadLine());
                return staticSalaries;
        }
    }   
}
