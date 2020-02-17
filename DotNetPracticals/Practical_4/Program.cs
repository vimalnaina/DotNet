using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int binary = 1010;
            DecimaltoBinary(number);
            Console.WriteLine();
            DecimaltoHex(number);
            Console.WriteLine();
            DecimaltoOctal(number);
            Console.WriteLine();
            BinarytoDecimal(binary);
            Console.ReadLine();
        }
        private static void DecimaltoBinary(int number)
        {
            Console.Write("Decimal : " + number);
            int[] a = new int[50];
            int i = 0;
            while (number > 0)
            {
                a[i] = (number % 2);
                i++;
                number /= 2;
            }
            Console.Write(" = Binary : ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(a[j]);
            }
        }
        private static void DecimaltoHex(int number)
        {
            Console.Write("Decimal : " + number);
            char[] a = new char[50];
            int i = 0;
            while (number > 0)
            {
                a[i] = (char)(number % 16);
                if (a[i] > 9)
                    a[i] = (char)(a[i] + 55);
                else
                    a[i] = (char)(a[i] + 48);
                number /= 16;
                i++;
            }
            Console.Write(" = Hex : ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(a[j]);
            }
        }
        private static void DecimaltoOctal(int number)
        {
            Console.Write("Decimal : " + number);
            int[] a = new int[50];
            int i = 0;
            while (number > 0)
            {
                a[i] = (number % 8);
                number /= 8;
                i++;
            }
            Console.Write(" = Octal : ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(a[j]);
            }
        }
        private static void BinarytoDecimal(int number)
        {
            Console.Write("Binary  : " + number);
            int[] a = new int[50];
            int i = 0;
            int d = 0, temp;
            while (number > 0)
            {
                temp = (number % 10);
                d += (int)(temp * Math.Pow(2, i));
                number /= 10;
                i++;
            }
            Console.WriteLine(" = Decimal : " + d);
        }

    }
}