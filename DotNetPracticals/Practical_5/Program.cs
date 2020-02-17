using System;
namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            String infix = "(x-y)*(w+z)";
            String postfix;
            myclass.Infixtopostfix(ref infix, out postfix);
            Console.WriteLine("infix string : " + infix);
            Console.WriteLine("postfix string is : " + postfix);
            Console.Read();
        }
    }
}
