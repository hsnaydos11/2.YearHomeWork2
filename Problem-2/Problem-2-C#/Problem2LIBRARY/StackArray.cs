using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2LIBRARY
{
    public class StackArray
    {
        private int[] ele;
        private int top;
        private int max;
        public StackArray(int size)
        {
            ele = new int[size]; // Maximum size of Stack
            top = -1;
            max = size;
        }
        public bool Arraypush(int item)  //to insert into stack
        {
            if (top == max - 1)  //if there is nothing to stack, to encounter 
            {
                return false;
            }
            else
            {
                ele[++top] = item; //to insert into stack
            }
            return true;
        }
        public int Arraypop()  //to delete item in stack
        {
            if (top == -1) //if there is no item in stack
            {
                return -1;
            }
            else
            {
                //to delete top item in stack
                Console.WriteLine("{0} popped from stack ", ele[top]);
                return ele[top--];
            }
        }
        public int Arraypeek()  //to find the highest item in stack
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                //to find the highest item in stack
                Console.WriteLine("{0} is top element of stack ", ele[top]);
                return ele[top];
            }
        }
        public int ArrayprintStack()  //to print item in stack
        {
            if (top == -1)  //there is nothin in stack, to print
            {
                return 0; 
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack", ele[i]);
                }
            }
            return 0;
        }
        public bool ArrayisEmpty() //if there is no item in stack, to determine
        {
            return (top < 0);
        }
    }
}
