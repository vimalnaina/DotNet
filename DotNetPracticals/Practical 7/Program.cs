using System;
using System.Globalization;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Figure in INR : ");
            String inr = Console.ReadLine();
            decimal ruppes = Decimal.Parse(inr);

            decimal dollar = 0.0139531M * ruppes;
            decimal pound = 0.0127937M * ruppes;
            decimal franc = 0.0135894M * ruppes;

            Console.WriteLine($"INR {ruppes} = {dollar.ToString("C",new CultureInfo("en-US"))}");
            Console.WriteLine($"INR {ruppes} = {pound.ToString("C", new CultureInfo("en-GB"))}");
            Console.WriteLine($"INR {ruppes} = {franc.ToString("C", new CultureInfo("de-CH"))}");
            Console.Read();
        }
    }
}
