using System.Collections.Generic;
using System.Linq;

namespace Practical_5
{
    class MyClass
    {
        public void Infixtopostfix(ref string infix, out string postfix)
        {
            postfix = "";
            char ch;
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];

                if (isoperator(ch))
                {
                    if (s.Count() == 0)
                    {
                        s.Push(ch);
                    }
                    else
                    {
                        if (ch == '(')
                        {
                            s.Push(ch);
                        }
                        else if (ch == ')')
                        {
                            while (s.Peek() != '(')
                            {
                                postfix += s.Pop();
                            }
                            s.Pop();
                        }
                        else
                        {
                            if (priority(ch) > priority(s.Peek()))
                            {
                                s.Push(ch);
                            }
                            else
                            {
                                postfix += s.Pop();
                                i--;
                            }
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
            foreach (var item in s)
            {
                postfix += item;
            }

        }

        public int priority(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                default:
                    return -1;
            }
        }

        public bool isoperator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '%' || ch == '(' || ch == ')')
            {
                return true;
            }
            return false;
        }


    }
}