using System;
using System.Collections;
using System.Collections.Generic;
using Problem_3Library;

namespace Problem_3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine("*****MENU*****\n1. Evaluate Infix\n2. Validate Infix\n3. InfixToPostfixConversion\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(InfixEvaluate.EvaluateInfix.evaluate("(1+5)*(5%(10*10))"));
                    break;
                case 2:
                    arr.Add("a+b*(c^d-e)^(f+g*h)-i");
                    foreach (string s1 in arr)
                    {
                        string s = s1;
                        s = "(" + s + ")";
                        s = s.Replace(" ", string.Empty);
                        Console.WriteLine("Exp : " + s);
                        Console.WriteLine(ValidateInfix.validate(s) == true ? "true" : "false");
                        Console.WriteLine();

                    }
                    Console.ReadLine();


                    Console.ReadLine();
                    break;
                case 3:
                    string exp = "a+b*(c^d-e)^(f+g*h)-i";
                    Console.WriteLine(InfixToPostfix.infixToPostfix(exp));
                    break;
            }
        }
    }
}
