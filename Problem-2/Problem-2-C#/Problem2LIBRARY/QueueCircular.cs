using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2LIBRARY
{
    public class QueueCircular
    {
        public class Node  //struct of node
        {
            public int data;
            public Node link;
        }
        public class LinkedList
        {
            public Node front, rear;
        }
        // Function to create Circular queue
        public static int enQueue(LinkedList q, int value) //to add item in queue
        {
            Node temp = new Node();
            temp.data = value;
            if (q.front == null)   //if there is no item in queue, to add empty storage
            {
                q.front = temp;
            }
            else
            {
                q.rear.link = temp;
            }
            q.rear = temp;
            q.rear.link = q.front;
            return value;
        }
        public static int deQueue(LinkedList q) //to delete item from circular queue
        {
            if (q.front == null)  //if there is no item in circular queue, to show item 
            {
                Console.Write("Queue is empty");
                return int.MinValue;
            }

            // If this is the last node to be deleted
            int value; // Value will be deleted
            if (q.front == q.rear)
            {
                value = q.front.data;
                q.front = null;
                q.rear = null;
            }
            else // There are more than one nodes
            {
                Node temp = q.front;
                value = temp.data;
                q.front = q.front.link;
                q.rear.link = q.front;
            }

            return value;
        }
        // Function displaying the elements
        // of Circular Queue
        public static int displayQueue(LinkedList q)  //to show item of circular queue
        {
            Node temp = q.front;
            Console.Write("\nElements in Circular Queue are: ");
            while (temp.link != q.front)
            {
                Console.Write("{0:D} ", temp.data);
                temp = temp.link;
            }
            Console.Write("{0:D}", temp.data);
            return 0;
        }
    }
}
