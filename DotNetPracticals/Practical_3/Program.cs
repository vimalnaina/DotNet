using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Your Country: ");
            country = Console.ReadLine();
            Console.WriteLine("Hi, " + name + " from country " + country);
            Console.Read();
        }
    }
}
