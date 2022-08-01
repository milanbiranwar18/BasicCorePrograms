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

        public static void HarmonicNumber()
        {
            double num = 0;
            int i;
            Console.Write("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0}", +i);
                num = num + (1 / (float)i);

            }
            Console.Write("Sum of Series upto{0} terms : {1} ", n, num);
            Console.ReadLine();
        }

        public static void Factor()
        {
            int n, i;
            Console.WriteLine("Enter the Number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of NUmber are:");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void EvenOdd()
        {
            int num = 0;

            Console.WriteLine("Enter 0 for Odd Numbers Or 1 for Even Numbers ");
            num = Convert.ToInt32(Console.ReadLine());
            // int num = int.Parse(Console.ReadLine());
            //Random random = new Random();
            //int num=random.Next(0, 2);
            if (num == 0)

            {
                Console.WriteLine("Odd Numbers are");
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Even Numbers are");
                for (int i = 0; i <= 100; i++)
                {

                    if (i % 2 == 1)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }
        }

        public static void VowelConsonant()
        {
            Console.WriteLine("Enter any Character");
            char ch = Convert.ToChar(Console.ReadLine());   

            if ((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch =='I' ||ch == 'O'|| ch == 'U'))
            {
                Console.WriteLine(ch + " is vowel");
            }
            else
            {
                Console.WriteLine(ch + " is Consonant");
            }
        }

        public static void QuotientandRemainder()
        {
            int divident = 25, divisor = 5;
            int quotient = divident/ divisor;
            int remainder = divident % divisor;

            Console.WriteLine("Quotient :" + quotient);
            Console.WriteLine("Remainder :" + remainder);
        }

        public static void SwapTwoNumber()
        {
            int a = 5, b = 10;
            Console.WriteLine("Before Swaping a = " + a + "b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swaping a = " + a + "b = " + b);

        }
    }
}
