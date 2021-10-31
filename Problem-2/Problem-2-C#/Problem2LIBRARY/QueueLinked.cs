using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2LIBRARY
{
    public class QNode  //Linked list node to store data in queue
    {
        public int key;
        public QNode next;

        // constructor to create
        // a new linked list node
        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
    public class QueueLinked  //to show and determine front and rear nodes of items
    {
        QNode front, rear;

        public QueueLinked()
        {
            this.front = this.rear = null;
        }

        // Method to add an key to the queue.
        public int enqueue(int key) 
        {

            // Create a new node
            QNode temp = new QNode(key);

            if (this.rear == null)  //if queue is empty, front and rear is both
            {
                this.front = this.rear = temp;
                return 0;
            }

            // Add the new node at the end of queue and change rear
            this.rear.next = temp;
            this.rear = temp;
            return key;
        }

        public int dequeue()  //to remove item in queue
        {
            // If queue is empty, return NULL.
            if (this.front == null)
                Console.WriteLine("Queue is empty!!!");
                return 0;

            // Store previous front and
            // move front one node ahead
            QNode temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL,
            // then change rear also as NULL
            if (this.front == null)
                this.rear = null;
            return 0;        
        }
    }

}
