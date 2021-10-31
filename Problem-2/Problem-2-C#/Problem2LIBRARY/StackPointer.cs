using System;

namespace Problem2LIBRARY
{
    public class StackPointer
    {
        //**********POINTER BASED STACK********
        StackNode root;
        public class StackNode     // A structure to represent a stack
        {
            public int data;
            public StackNode next;

            public StackNode(int data) { this.data = data; }
        }
        public bool PointerisEmpty() //if struct is empty, to return root
        {
            if (root == null)
            {
                return true;
            }
            else
                return false;
        }
        public int Pointerpush(int data)  //to insert item in stack
        {
            StackNode newNode = new StackNode(data);

            if (root == null)  //there is nothing, to return node
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
        public int Pointerpop()  //to delete item in stack
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
        public int Pointerpeek()  //to find the highest item in stack
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
