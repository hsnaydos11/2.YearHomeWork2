using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3Library
{
    public class InfixEvaluate
    {
        public class EvaluateInfix
        {
            public static int evaluate(string expression)
            {
                char[] tokens = expression.ToCharArray();

                // Stack for numbers: 'values'
                Stack<int> values = new Stack<int>(); //to store integer data

                // Stack for Operators: 'ops'
                Stack<char> ops = new Stack<char>(); //to store operator

                for (int i = 0; i < tokens.Length; i++)
                {
                    // Current token is a whitespace, skip it
                    if (tokens[i] == ' ') //to skip because of empty token
                    {
                        continue;
                    }

                    // Current token is a number,
                    // push it to stack for numbers
                    if (tokens[i] >= '0' && tokens[i] <= '9') //current token is number, insert it in stack
                    {
                        StringBuilder sbuf = new StringBuilder();

                        // There may be more than one digits in number
                        while (i < tokens.Length &&
                                tokens[i] >= '0' &&
                                    tokens[i] <= '9')
                        {
                            sbuf.Append(tokens[i++]);
                        }
                        values.Push(int.Parse(sbuf.ToString()));

                        //where the loop increases i and we decrease i here to complete the offset.
                        i--;
                    }

                    // Closing brace encountered, solve entire brace.
                    else if (tokens[i] == '(')
                    {
                        ops.Push(tokens[i]);
                    }

                    // Closing brace encountered,
                    // solve entire brace
                    else if (tokens[i] == ')')
                    {
                        while (ops.Peek() != '(')
                        {
                            values.Push(applyOp(ops.Pop(),
                                             values.Pop(),
                                            values.Pop()));
                        }
                        ops.Pop();
                    }

                    // Function to perform arithmetic operations.
                    else if (tokens[i] == '+' ||
                             tokens[i] == '-' ||
                             tokens[i] == '*' ||
                             tokens[i] == '/')
                    {

                        // While top of 'ops' has same
                        // or greater precedence to current
                        // token, which is an operator.
                        // Apply operator on top of 'ops'
                        // to top two elements in values stack
                        while (ops.Count > 0 &&
                                 hasPrecedence(tokens[i],
                                             ops.Peek()))
                        {
                            values.Push(applyOp(ops.Pop(),
                                             values.Pop(),
                                           values.Pop()));
                        }

                        // Push current token to 'ops'.
                        ops.Push(tokens[i]);
                    }
                }

                //All expressions are decomposed into their values.To continue the proceedings
                while (ops.Count > 0)
                {
                    values.Push(applyOp(ops.Pop(),
                                     values.Pop(),
                                    values.Pop()));
                }

                return values.Pop(); // Top of 'values' contains result, return it.
            }

            public static bool hasPrecedence(char op1, //to find precedence of operators "+,-,*,/"
                                             char op2)
            {
                if (op2 == '(' || op2 == ')')
                {
                    return false;
                }
                if ((op1 == '*' || op1 == '/') &&
                       (op2 == '+' || op2 == '-'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            // A utility method to apply an
            // operator 'op' on operands 'a' 
            // and 'b'. Return the result.
            public static int applyOp(char op, int b, int a) // Function to perform arithmetic operations.
            {
                switch (op)
                {
                    case '+':
                        return a + b;
                    case '-':
                        return a - b;
                    case '*':
                        return a * b;
                    case '/':
                        if (b == 0)
                        {
                            throw new
                            System.NotSupportedException(
                                   "Cannot divide by zero");
                        }
                        return a / b;
                }
                return 0;
            }
        }
    }
}
