using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3Library
{
    public class ValidateInfix
    {
        public static bool validate(string expression)  //to confirm expression is true or false
        {
            int previous = 0;
            int previous1 = 0;
            string expEvaluated = string.Empty;
            int operatorOperand = 1;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == ')')  //if encountered ")", stop process
                {
                }
                else
                if (c == '(')  //if encountered "(", start process until ")"
                {
                    int j = expression.IndexOf(')', i);
                    if (j == -1)
                        return false;

                    string substring = expression.Substring(i + 1, j - i - 1);

                    while (getcharactercount(substring, '(') != getcharactercount(substring, ')'))   
                    {
                        if (j < expression.Length - 1)
                            j = expression.IndexOf(')', j + 1);
                        else
                            break;

                        substring = expression.Substring(i + 1, j - i - 1);
                    }

                    i = j - 1; //Changing the counter i to point to the next character
                    //validating the sub expression
                    if (validate(substring) == true)
                    {
                        if (previous != 0 && previous1 != 0 && previous > previous1)
                        {
                            previous1 = operatorOperand;
                            operatorOperand++;
                            previous = 0;
                        }
                        else if (previous != 0 && previous1 != 0 && previous <= previous1)
                        {
                            return false;
                        }
                        else if (previous1 != 0)
                        {
                            return false;
                        }
                        else
                        {
                            previous1 = operatorOperand;
                            operatorOperand++;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                    if (c == '+'                      // Function to perform arithmetic operations.
                   || c == '-'
                   || c == '*'
                   || c == '/')
                {
                    if (previous != 0) 
                    {
                        return false;
                    }
                    previous = operatorOperand;
                    operatorOperand++;
                }
                else
                {
                    if (previous != 0 && previous1 != 0 && previous > previous1)
                    {
                        previous1 = operatorOperand;
                        operatorOperand++;
                        previous = 0;
                    }
                    else if (previous != 0 && previous1 != 0 && previous <= previous1)
                    {
                        return false;
                    }
                    else if (previous1 != 0)
                    {
                        return false;
                    }
                    else
                    {
                        previous1 = operatorOperand;
                        operatorOperand++;
                    }
                }
            }
            if (previous != 0)
                return false;
            return true;
        }

        public static int getcharactercount(string exp, char _c)  //to get the number of desired operation
        {
            int count = 0;
            foreach (char c in exp)
            {
                if (c == _c)
                    count++;
            }
            return count;
        }

    }
}
