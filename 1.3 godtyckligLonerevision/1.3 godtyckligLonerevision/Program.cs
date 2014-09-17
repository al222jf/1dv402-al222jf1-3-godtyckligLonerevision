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
            //User input number of saleries
            int numberOfSalaries = ReadInt("Ange antal löner att mata in: ");
            //User inputs salaries
            
        }
        private static void ProcessSalaries(int count)
        {
            throw new NotImplementedException();
        }
        private static int ReadInt(string prompt) 
        {
            Console.Write(prompt);
            int staticSalaries = int.Parse(Console.ReadLine());
                return staticSalaries;
        }
    }   
}
