using System;

namespace Problem_2
{
    public class Problem_2Library
    {
        //*********ARRAY BASED STACK********
        class Stack
        {
            private int[] ele;
            private int top;
            private int max;
            public Stack(int size)
            {
                ele = new int[size]; // Maximum size of Stack
                top = -1;
                max = size;
            }
            public bool Arraypush(int item)
            {
                if (top == max - 1)
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
                else
                {
                    ele[++top] = item;
                }
                return true;
            }
            public int Arraypop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return -1;
                }
                else
                {
                    Console.WriteLine("{0} popped from stack ", ele[top]);
                    return ele[top--];
                }
            }
            public int Arraypeek()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return -1;
                }
                else
                {
                    Console.WriteLine("{0} popped from stack ", ele[top]);
                    return ele[top];
                }
            }
            public void ArrayprintStack()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return;
                }
                else
                {
                    for (int i = 0; i <= top; i++)
                    {
                        Console.WriteLine("{0} pushed into stack", ele[i]);
                    }
                }
            }
            public bool ArrayisEmpty()
            {
                return (top < 0);
            }
        }
            //**********POINTER BASED STACK********
            StackNode root;
        public class StackNode
        {
            public int data;
            public StackNode next;

            public StackNode(int data) { this.data = data; }
        }
        public bool PointerisEmpty()
        {
            if (root == null)
            {
                return true;
            }
            else
                return false;
        }
        public int Pointerpush(int data)
        {
            StackNode newNode = new StackNode(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                StackNode temp = root;
                root = newNode;
                newNode.next = temp;
            }
            Console.WriteLine(data + " pushed to stack");
            return data;
        }
        public int Pointerpop()
        {
            int popped = int.MinValue;
            if (root == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                popped = root.data;
                root = root.next;
            }
            return popped;
        }
        public int Pointerpeek()
        {
            if (root == null)
            {
                Console.WriteLine("Stack is empty");
                return int.MinValue;
            }
            else
            {
                return root.data;
            }
        }
    }
}
