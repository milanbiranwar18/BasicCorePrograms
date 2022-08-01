using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LogicalProgram
    {
        public static void leap_year()
        {
            int year;
            Console.Write("Enter the Year :");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))


                Console.WriteLine("Year is Leap Year");
            else
                Console.WriteLine("Year is not a Leap Year");
        }
        
        public static void PowerOfTwo()
        {
            int n = 31;
            int var = 1;

            for (int i = 1; i < n; i++)
            {
                var = var * 2;
                Console.WriteLine(var);
            }
        }
    }
}
