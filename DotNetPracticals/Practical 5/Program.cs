using System;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            string infix = "a+b*c+d/e";
            string postfix;
            StringConversion sc = new StringConversion();
            sc.InfixToPostfix(infix, out postfix);
            Console.WriteLine(postfix);
            Console.Read();
        }
    }
}
