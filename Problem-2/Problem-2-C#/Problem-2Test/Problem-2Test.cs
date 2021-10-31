using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2LIBRARY;

namespace Problem_2Test
{
    //*********STACK ARRAY BASED********
    [TestClass]
    public class StackArrPush
    {
        [TestMethod]
        public void GoodCase()
        {
            StackArray p = new StackArray(5);
            p.Arraypush(10);
            p.Arraypush(20);
            p.Arraypush(30);
            bool result = p.Arraypush(10);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void BadCase()
        {
            StackArray p = new StackArray(5);
            p.Arraypush(10);
            p.Arraypush(20);
            p.Arraypush(30);
            bool result = p.Arraypush(20);
            Assert.AreNotEqual(false, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            StackArray p = new StackArray(5);
            p.Arraypush(10);
            p.Arraypush(20);
            p.Arraypush(30);

            bool result = p.Arraypush(20);
            Assert.AreNotSame(false, result);
        }
    }
    [TestClass]
    public class StackArrPop
    {
        [TestMethod]
        public void GoodCase()
        {
            StackArray p = new StackArray(5);
            StackArray p1 = new StackArray(5);
            StackArray p2 = new StackArray(5);
            p.Arraypush(10);
            p1.Arraypush(20);
            p2.Arraypush(30);
            int result = p.Arraypop();
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void BadCase()
        {
            StackArray p = new StackArray(5);
            StackArray p1 = new StackArray(5);
            StackArray p2 = new StackArray(5);
            p.Arraypush(10);
            p1.Arraypush(20);
            p2.Arraypush(30);
            int result = p1.Arraypop();
            Assert.AreNotEqual(10, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            StackArray p = new StackArray(5);
            StackArray p1 = new StackArray(5);
            StackArray p2 = new StackArray(5);
            p.Arraypush(10);
            p1.Arraypush(20);
            p2.Arraypush(30);
            int result = p2.Arraypop();
            Assert.AreNotSame(20,result);
        }
    }
    [TestClass]
    public class StackArrTop
    {
        [TestMethod]
        public void GoodCase()
        {
            StackArray p = new StackArray(5);
            p.Arraypush(10);
            p.Arraypush(20);
            p.Arraypush(30);
            p.Arraypush(40);
            p.Arraypeek();
            int result = p.Arraypeek();
            Assert.AreEqual(40, result);
        }
        [TestMethod]
        public void BadCase()
        {
            StackArray p = new StackArray(5);
            p.Arraypush(10);
            p.Arraypush(20);
            p.Arraypush(30);
            p.Arraypeek();
            int result = p.Arraypeek();
            Assert.AreNotEqual(20, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            StackArray p = new StackArray(5);
            p.Arraypush(10);
            p.Arraypush(20);
            p.Arraypush(30);
            p.Arraypeek();
            int result = p.Arraypeek();
            Assert.AreNotSame(10, result);
        }
    }
    //*********STACK POINTER BASED********
    [TestClass]
    public class StackPointerPush
    {
        [TestMethod]
        public void GoodCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpush(20);
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void BadCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpush(10);
            Assert.AreNotEqual(20, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpush(30);
            Assert.AreNotSame(20, result);
        }
    }
    [TestClass]
        public class StackPointerPop
    {
        [TestMethod]
        public void GoodCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpop();
            Assert.AreEqual(30,result);

        }
        [TestMethod]
        public void BadCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpop();
            Assert.AreNotEqual(20, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpop();
            Assert.AreNotSame(10, result);
        }
    }
    [TestClass]
    public class StackPointerTop
    {
        [TestMethod]
        public void GoodCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpeek();
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void BadCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpeek();
            Assert.AreNotEqual(20, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            StackPointer sll = new StackPointer();
            sll.Pointerpush(10);
            sll.Pointerpush(20);
            sll.Pointerpush(30);
            int result = sll.Pointerpeek();
            Assert.AreNotSame(20, result);
        }
    } 
    //*********QUEUE ARRAY BASED********
    [TestClass]
    public class ArrayQueueEnqueue
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(10);
            Q.Arrayenqueue(20);
            Q.Arrayenqueue(30);
            Q.Arrayenqueue(40);
            int result = Q.Arrayenqueue(10);
            Assert.AreEqual(10,result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(10);
            Q.Arrayenqueue(20);
            Q.Arrayenqueue(30);
            Q.Arrayenqueue(40);
            int result = Q.Arrayenqueue(30);
            Assert.AreNotEqual(10, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(10);
            Q.Arrayenqueue(20);
            Q.Arrayenqueue(30);
            Q.Arrayenqueue(40);
            int result = Q.Arrayenqueue(20);
            Assert.AreNotSame(10, result);
        }
    }
    [TestClass]
    public class ArrayQueueDequeue
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(10);
            Q.Arrayenqueue(20);
            Q.Arrayenqueue(30);
            Q.Arrayenqueue(40);
            Q.Arraydequeue();
            int result = Q.Arraydequeue();
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(10);
            Q.Arrayenqueue(20);
            Q.Arrayenqueue(30);
            Q.Arrayenqueue(40);
            Q.Arraydequeue();
            int result = Q.Arraydequeue();
            Assert.AreNotEqual(30, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(10);
            Q.Arrayenqueue(20);
            Q.Arrayenqueue(30);
            Q.Arrayenqueue(40);
            Q.Arraydequeue();
            int result = Q.Arraydequeue();
            Assert.AreNotSame(30, result);
        }
    }
    [TestClass]
    public class ArrayQueueIsEmpty
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueArray Q = new QueueArray(5);
            int result = Q.ArrayprintQueue();
            Assert.AreEqual(Q.ArrayprintQueue(), result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(20);
            int result = Q.ArrayprintQueue();
            Assert.AreNotEqual(20,result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueArray Q = new QueueArray(5);
            Q.Arrayenqueue(10);
            int result =Q.ArrayprintQueue();
            Assert.AreNotSame(20,result);
        }
    }
    //********QUEUE CIRCULAR LIST*******
    [TestClass]
    public class CircularQueueEnqueue
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            QueueCircular.enQueue(c, 22);
            QueueCircular.enQueue(c, 6);
            int result = QueueCircular.enQueue(c, 6);
            Assert.AreEqual(6, result); 
        }
        [TestMethod]
        public void BadCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            QueueCircular.enQueue(c, 22);
            QueueCircular.enQueue(c, 6);
            int result = QueueCircular.enQueue(c, 14);
            Assert.AreNotEqual(6, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            QueueCircular.enQueue(c, 22);
            QueueCircular.enQueue(c, 6);
            int result = QueueCircular.enQueue(c, 22);
            Assert.AreNotSame(6, result);
        }
    }
    [TestClass]
    public class CircularQueueDequeue
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            QueueCircular.enQueue(c, 22);
            QueueCircular.enQueue(c, 6);
            int result = QueueCircular.deQueue(c);
            Assert.AreEqual(14, result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            QueueCircular.enQueue(c, 22);
            QueueCircular.enQueue(c, 6);
            int result = QueueCircular.deQueue(c);
            Assert.AreNotEqual(22, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            QueueCircular.enQueue(c, 22);
            QueueCircular.enQueue(c, 6);
            int result = QueueCircular.deQueue(c);
            Assert.AreNotSame(22, result);
        }
    }
    [TestClass]
    public class CircularQueueEmpty
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            int result = QueueCircular.deQueue(c);
            Assert.AreEqual(QueueCircular.deQueue(c),result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            int result = QueueCircular.deQueue(c);
            Assert.AreNotEqual(QueueCircular.deQueue(c), result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueCircular.LinkedList c = new QueueCircular.LinkedList();
            c.front = c.rear = null;
            QueueCircular.enQueue(c, 14);
            int result = QueueCircular.deQueue(c);
            Assert.AreNotSame(QueueCircular.deQueue(c), result);
        }
    }
    //*********QUEUE Linked LIST******
    [TestClass]
    public class LinkedQueueEnqueue
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueLinked q = new QueueLinked();
            q.enqueue(10);
            q.enqueue(20);
            int result = q.enqueue(20);
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueLinked q = new QueueLinked();
            q.enqueue(10);
            q.enqueue(20);
            int result = q.enqueue(10);
            Assert.AreNotEqual(20, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueLinked q = new QueueLinked();
            q.enqueue(10);
            q.enqueue(20);
            int result = q.enqueue(10);
            Assert.AreNotSame(20, result);
        }
    }
    [TestClass]
    public class LinkedQueueDequeue
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueLinked q = new QueueLinked();
            q.enqueue(0);
            q.enqueue(20);
            int result = q.dequeue();
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueLinked q = new QueueLinked();
            q.enqueue(10);
            q.enqueue(20);
            q.enqueue(30);
            int result = q.dequeue();
            Assert.AreNotEqual(10, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueLinked q = new QueueLinked();
            q.enqueue(10);
            q.enqueue(20);
            q.enqueue(30);
            int result = q.dequeue();
            Assert.AreNotSame(20, result);
        }
    }
    [TestClass]
    public class LinkedQueueEmpty
    {
        [TestMethod]
        public void GoodCase()
        {
            QueueLinked q = new QueueLinked();
            q.dequeue();
            int result = q.dequeue();
            Assert.AreEqual(q.dequeue(), result);
        }
        [TestMethod]
        public void BadCase()
        {
            QueueLinked q = new QueueLinked();
            q.dequeue();
            int result = q.dequeue();
            Assert.AreEqual(q.dequeue(), result);
        }
        [TestMethod]
        public void UglyCase()
        {
            QueueLinked q = new QueueLinked();
            q.enqueue(10);
            q.enqueue(20);
            q.dequeue();
            int result = q.dequeue();
            Assert.AreNotSame(q.dequeue(), result);
        }
    }
}
