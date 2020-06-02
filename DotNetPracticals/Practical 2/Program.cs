
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----First Pattern----");
        Pattern1();
        Console.WriteLine("----Second Pattern----");
        Pattern2();
        Console.WriteLine("----Third Pattern----");
        Pattern3();
        Console.WriteLine("----Fourth Pattern----");
        Pattern4();
        Console.ReadKey();
    }
    static void Pattern1()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Pattern2()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Pattern3()
    {
        int i, j;
        for (i = 5; i >= 1; i--)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Pattern4()
    {
        int i, j, k;
        for (i = 1; i <= 5; i++)
        {
            for (j = 5 - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
 }

 }
