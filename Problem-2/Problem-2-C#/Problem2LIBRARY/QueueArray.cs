using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2LIBRARY
{
    public class QueueArray
    {
        // Constructor to initialize a queue
        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public QueueArray(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        // Function to add an item to the queue.
        // It changes rear and size
        public int Arrayenqueue(int item) 
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return max-1;
            }
            else
            {
                ele[++rear] = item; //to add item to queue 
            }
            return item;
        }

        // Function to remove an item from queue.
        // It changes front and size
        public int Arraydequeue()
        {
            if (front == rear + 1)   //if there is nothing to delete, show queue is empty
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {  
                //delete item in queue
                Console.WriteLine(ele[front] + " dequeued from queue");
                int p = ele[front++];
                Console.WriteLine();
                return p;
            }
        }

        // Function to print queue.
        public int ArrayprintQueue()
        {
            if (front == rear + 1) //if there is nothing to show, print to screen
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }
            else
            {
                //if there are items in queue, print items to screen
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(ele[i] + " enqueued to queue");
                }
            }
            return 0;
        }
        public int ArrayCount()   //to print first item and last item
        {
            int p = ele[front++];
            Console.WriteLine();
            Console.WriteLine("Front item is {0}", ele[front]);
            Console.WriteLine("Rear item is {0} ", ele[rear]);
            return p;
        }
    }
}
