using System;

namespace Practical9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice : ");
            Console.WriteLine("1. C to F");
            Console.WriteLine("2. F to C");
            Int64 choice = Int64.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                         Console.WriteLine("Enter Calcius value : ");
                         float c = float.Parse(Console.ReadLine());
                         float f = (c * 9) / 5 + 32;
                         Console.WriteLine(c + "C = " + f + " F");
                break;

                case 2:
                    Console.WriteLine("Enter Fahrenheit value : ");
                    float fe = float.Parse(Console.ReadLine());
                    float ce = (fe-32)*5/9;
                    Console.WriteLine(fe + "F = " + ce +" C");
                    break;
            }
        }
    }
}
