using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3Library
{
    public class InfixToPostfix
    {
        // A utility function to return
        // precedence of a given operator
        // Higher returned value means higher precedence
        internal static int Prec(char ch) //to find precedence of operators "+,-,*,/"
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }

        // The main method that converts given infix expression to postfix expression. 
        public static string infixToPostfix(string exp)
        {
            string result = "";  //start show empty for result

            Stack<char> stack = new Stack<char>(); //starting empty stack in process

            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i];

                // If the scanned character is an operand, add it to output.
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }

                // If the scanned character is an '(', push it to the stack.
                else if (c == '(')
                {
                    stack.Push(c);
                }

                else if (c == ')') //when it sees ")" , stop process until ")" is encoutered.
                {
                    while (stack.Count > 0 &&
                            stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(') //if "(" encountered, to show invalid expressipn
                    {
                        return "Invalid Expression"; 
                    }
                    else
                    {
                        stack.Pop();  //to delete expression
                    }
                }
                else // an operator is encountered
                {
                    while (stack.Count > 0 && Prec(c) <=
                                      Prec(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }

            }

            // pop all the operators from the stack
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;
        }
    }
}
