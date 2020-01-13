using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1();
            pattern2();
            pattern3();
            Console.Read();
        }

        private static void pattern3()
        {
            Console.WriteLine("\nPattern:3\n");
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < 5; j++) 
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        private static void pattern2()
        {
            Console.WriteLine("\nPattern:2\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void pattern1()
        {
            Console.WriteLine("Pattern:1\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
