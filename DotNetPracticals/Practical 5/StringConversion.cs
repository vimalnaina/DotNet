using System;
using System.Collections.Generic;
using System.Text;

namespace Practical5
{
    class StringConversion
    {
        public void InfixToPostfix(string infix , out string postfix)
        {
            postfix = "";
            Stack<char> stack = new Stack<char>();
            char ch;
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if (isOperator(ch))
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(ch);
                    }
                    else 
                    {
                        if(ch == '(')
                        {
                            stack.Push(ch);
                        }
                        else if(ch == ')')
                        {
                            while(stack.Peek()!='(')
                            {
                                postfix += stack.Pop();
                            }
                            stack.Pop();
                                  
                        }
                        else if (priority(ch) > priority(stack.Peek()))
                        {
                            stack.Push(ch);
                        }
                        else
                        {
                           postfix+= stack.Pop();
                            i--;
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
                
            }
            foreach (var item in stack)
            {
                postfix += item;
            }
        }

        
        private int priority(char ch)
        {
            int priority = 0;
            switch(ch)
            {
                case '+':
                    priority = 0;
                    break;
                case '-':
                    priority= 0;
                    break;
                case '*':
                    priority = 1;
                    break;
                case '/':
                    priority=1;
                    break;
            }
            return priority;    
        }

        private bool isOperator(char ch)
        {
            int ach = ch;
            if (ach >=40 && ach <=47)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
