using System;
using Problem2LIBRARY;

namespace Problem_2Console
{
    class Problem_2Console
    {
        static void Main(string[] args)
        {
            StackArray p = new StackArray(5);
            QueueArray Q = new QueueArray(5);
            StackPointer sll = new StackPointer();
            QueueLinked q = new QueueLinked();
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            Console.WriteLine("\n\n*****MAIN MENU*****");
            Console.WriteLine("\nPlease enter the number for functions:");
            Console.WriteLine("\n1-)Stack Array Based\n2-)Stack Pointer Based\n3-)Queue Array Based\n4-)Queue Single Linked List\n5-)Queue Circular Linked List\n6-)Exit\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n1.Push\n2.Pop\n3.top\n4.IsEmpty\n5.Count");
                    int choice1 = Convert.ToInt32(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            p.Arraypush(10);
                            p.Arraypush(20);
                            p.Arraypush(30);
                            p.ArrayprintStack();
                            break;
                        case 2:
                            p.Arraypush(10);
                            p.Arraypush(20);
                            p.Arraypush(30);
                            p.ArrayprintStack();
                            p.Arraypop();
                            break;
                        case 3:
                            p.Arraypush(10);
                            p.Arraypush(20);
                            p.Arraypush(30);
                            p.Arraypeek();
                            break;
                        case 4:
                            Console.WriteLine("Stack is empty!!!!");
                            p.ArrayisEmpty();
                            break;
                        case 5:
                            p.Arraypush(10);
                            p.Arraypush(20);
                            p.Arraypush(30);
                            p.ArrayprintStack();
                            p.Arraypop();
                            Console.WriteLine("Elements present is stack :");
                            while (!p.ArrayisEmpty())
                            {
                                p.Arraypop();
                            }
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("\n1.Push\n2.Pop\n3.top\n4.IsEmpty\n5.Count");
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            sll.Pointerpush(10);
                            sll.Pointerpush(20);
                            sll.Pointerpush(30);
                            break;
                        case 2:
                            sll.Pointerpush(10);
                            sll.Pointerpush(20);
                            sll.Pointerpush(30);

                            Console.WriteLine(sll.Pointerpop() + " popped from stack");
                            break;
                        case 3:
                            sll.Pointerpush(10);
                            sll.Pointerpush(20);
                            sll.Pointerpush(30);

                            Console.WriteLine("Top element is " + sll.Pointerpeek());
                            break;
                        case 4:
                            Console.WriteLine("Stack is Empty!!!!");
                            sll.PointerisEmpty();
                            break;
                        case 5:
                            sll.Pointerpush(10);
                            sll.Pointerpush(20);
                            sll.Pointerpush(30);
                            Console.WriteLine("Elements present is stack :");
                            while (!sll.PointerisEmpty())
                            {
                                sll.Pointerpeek();
                                sll.Pointerpop();
                            }
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("\n1.Enqueue\n2.Dequeue\n3.IsEmpty\n4.Count\n");
                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    switch (choice3) 
                    {
                        case 1:
                            Q.Arrayenqueue(10);
                            Q.Arrayenqueue(20);
                            Q.Arrayenqueue(30);
                            Q.Arrayenqueue(40);
                            Q.ArrayprintQueue();
                            break;
                        case 2:
                            Q.Arrayenqueue(10);
                            Q.Arrayenqueue(20);
                            Q.Arrayenqueue(30);
                            Q.Arrayenqueue(40);
                            Q.ArrayprintQueue();
                            Q.Arraydequeue();
                            break;
                        case 3:
                            Q.ArrayprintQueue();
                            break;
                        case 4:
                            Q.Arrayenqueue(10);
                            Q.Arrayenqueue(20);
                            Q.Arrayenqueue(30);
                            Q.Arrayenqueue(40);
                            Q.ArrayprintQueue();
                            Q.Arraydequeue();
                            Q.ArrayCount();
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("\n1.Enqueue\n2.Dequeue\n3.IsEmpty\n4.Count\n");
                    int choice4 = Convert.ToInt32(Console.ReadLine());
                    switch (choice4)
                    {
                        case 1:
                            q.enqueue(10);
                            Console.WriteLine("ADDING " + q.enqueue(10));
                            q.enqueue(20);
                            Console.WriteLine("ADDING " + q.enqueue(20));
                            break;
                        case 2:
                            q.enqueue(10);
                            Console.WriteLine("ADDING " + q.enqueue(10));
                            q.enqueue(20);
                            Console.WriteLine("ADDING " + q.enqueue(20));
                            q.dequeue();
                            Console.WriteLine("DELETED " + q.dequeue());
                            break;
                        case 3:
                            q.dequeue();
                            break;
                        case 4:
                            q.enqueue(10);
                            Console.WriteLine("ADDING " + q.enqueue(10));
                            q.enqueue(20);
                            Console.WriteLine("ADDING " + q.enqueue(20));
                            q.dequeue();
                            q.enqueue(30);
                            Console.WriteLine("ADDING " + q.enqueue(30));
                            q.enqueue(40);
                            Console.WriteLine("ADDING " + q.enqueue(40));
                            q.dequeue();
                            //Console.WriteLine("Queue Front : " + q.front.key);
                            //Console.WriteLine("Queue Rear : " + q.rear.key);
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("\n1.Enqueue\n2.Dequeue\n3.IsEmpty\n4.Count\n");
                    int choice5 = Convert.ToInt32(Console.ReadLine());
                    switch (choice5)
                    {
                        case 1:
                            QueueCircular.enQueue(c, 14);
                            QueueCircular.enQueue(c, 22);
                            QueueCircular.enQueue(c, 6);
                            QueueCircular.displayQueue(c);
                            break;
                        case 2:
                            QueueCircular.enQueue(c, 14);
                            QueueCircular.enQueue(c, 22);
                            QueueCircular.enQueue(c, 6);
                            QueueCircular.displayQueue(c);
                            Console.Write("\nDeleted value = {0:D}", QueueCircular.deQueue(c));
                            break;
                        case 3:
                            QueueCircular.deQueue(c);
                            break;
                        case 4:
                            QueueCircular.enQueue(c, 14);
                            QueueCircular.enQueue(c, 22);
                            QueueCircular.enQueue(c, 6);
                            QueueCircular.displayQueue(c);
                            QueueCircular.deQueue(c);
                            break;
                    }
                    break;
            }
        }
    }
}
