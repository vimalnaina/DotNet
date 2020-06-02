  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical5
{
    class Program
    {
        static void btod(string binary)
        {
            double sum = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                sum += Math.Pow(2, binary.Length - (i + 1)) * char.GetNumericValue(binary[i]);
            }
            Console.WriteLine("Decimal number is: " + sum);
        }
        static void dtob(string decimalString)
        {
            string binary = "";
            string binaryres = "";
            int value = Int16.Parse(decimalString);
            while (value > 0)
            {
                binary += value % 2;
                value = value / 2;
            }
            int len = binary.Length - 1;
            while (len >= 0)
            {
                binaryres = binaryres + binary[len];
                len--;
            }
            Console.WriteLine("Binary number is: " + binaryres);
        }
        static void dtoh(string decimalString)
        {
            string hex = "";
            string hexres = "";
            int value = Int16.Parse(decimalString);
            while (value > 0)
            {
                int ans = value % 16;
                switch (ans)
                {
                    case 10:
                        hex += "A";
                        break;
                    case 11:
                        hex += "B";
                        break;
                    case 12:
                        hex += "C";
                        break;
                    case 13:
                        hex += "D";
                        break;
                    case 14:
                        hex += "E";
                        break;
                    case 15:
                        hex += "F";
                        break;
                    default:
                        hex += value % 16;
                        break;
                }
                value = value / 16;
            }
            int len = hex.Length - 1;
            while (len >= 0)
            {
                hexres = hexres + hex[len];
                len--;
            }
            Console.WriteLine("Hexadecimal number is: " + hexres);
        }
        static void dtoO(string decimalString)
        {
            string octal = "";
            string octalres = "";
            int value = Int16.Parse(decimalString);
            while (value > 0)
            {
                octal += value % 8;
                value = value / 8;
            }
            int len = octal.Length - 1;
            while (len >= 0)
            {
                octalres = octalres + octal[len];
                len--;
            }
            Console.WriteLine("Octal number is: " + octalres);
        }
        static void Main(string[] args)
        {
            String input;
            Console.WriteLine("Conversions Available");
            Console.WriteLine("1. Binary to Decimal");
            Console.WriteLine("2. Decimal to Binary");
            Console.WriteLine("3. Decimal to Hexadecimal");
            Console.WriteLine("4. Decimal to Octal");
            Console.Write("Your choice: ");
            input = Console.ReadLine();
            if (!Regex.IsMatch(input, @"^[1-4]$"))
            {
                Console.WriteLine("Please choose valid choice");
            }
            else
            {
                int choice = Int16.Parse(input);
                string num;
                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter binary number: ");
                        num = Console.ReadLine();
                        btod(num);
                        break;
                    case 2:
                        Console.Write("Please enter decimal number: ");
                        num = Console.ReadLine();
                        dtob(num);
                        break;
                    case 3:
                        Console.Write("Please enter decimal number: ");
                        num = Console.ReadLine();
                        dtoh(num);
                        break;
                    case 4:
                        Console.Write("Please enter decimal number: ");
                        num = Console.ReadLine();
                        dtoO(num);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
