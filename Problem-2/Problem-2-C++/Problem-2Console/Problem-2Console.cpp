#include "../Problem-2/Header.h"
#include "../Problem-2/Problem-2.cpp"
#define CRT_SECURE_NO_WARNINGS

int main()
{
    int value, choice, choice1;
    class Stack s, s1, s2;
    StackNode* root = NULL;
    queue q(5);
    Queue q1;
    CircularQueue* cq = new CircularQueue;
    cq->front = cq->rear = NULL;
    cout << "\n\n*****MAINMENU*****";
    cout << "\nPlease enter number that you want to calculate";
    cout << "\n1-)Stack Array Based\n2-)Stack Pointer Based\n3-)Queue Array Based\n4-)Queue Single Linked List\n5-)Queue Circular Linked List\n6-)Exit\n";
    scanf_s("%d", &choice);
    switch (choice) {
    case 1:
        cout << "\n1. Push\n2. Pop\n3. top\n4. Count\n5. Exit\n";
        scanf_s("%d", &choice1);
        switch (choice1) {
        case 1:
            s.Arraypush(10);
            s.Arraypush(20);
            s.Arraypush(30);
            break;
        case 2:
            s.Arraypush(10);
            s.Arraypush(20);
            s.Arraypush(30);
            cout << s.Arraypop() << " Popped from stack\n";
            break;
        case 3:
            s.Arraypush(10);
            s.Arraypush(20);
            s.Arraypush(30);
            cout << "Top element is ";
            cout << s.Arraytop();
            break;
        case 4:
            s.Arraypush(10);
            s.Arraypush(20);
            s.Arraypush(30);
            cout << s.Arraypop() << " Popped from stack\n";
            cout << "Elements present in stack : ";
            while (!s.ArrayisEmpty())
            {
                cout << s.Arraytop() << " ";
                s.Arraypop();
            }
            break;
        case 5:
            exit(0);
            break;
        }
        break;
    case 2:
        cout << "\n1. Push\n2. Pop\n3. top\n4. Count\n5. Exit\n";
        scanf_s("%d", &choice1);
        switch (choice1) {
        case 1:
            Pointerpush(&root, 10);
            Pointerpush(&root, 20);
            Pointerpush(&root, 30);
            break;
        case 2:
            Pointerpush(&root, 10);
            Pointerpush(&root, 20);
            Pointerpush(&root, 30);
            cout << Pointerpop(&root) << " popped from stack\n";
            break;
        case 3:
            Pointerpush(&root, 10);
            Pointerpush(&root, 20);
            Pointerpush(&root, 30);
            cout << "Top element is " << Pointerpeek(root) << endl;
            break;
        case 4:
            Pointerpush(&root, 10);
            Pointerpush(&root, 20);
            Pointerpush(&root, 30);

            cout << Pointerpop(&root) << " popped from stack\n";

            cout << "Elements present in stack : ";
            while (!PointerisEmpty(root))
            {
                cout << Pointerpeek(root) << " ";
                Pointerpop(&root);
            }
            break;
        }
        break;
    case 3:
        cout << "\n1. Enqueue\n2. Dequeue\n3. IsEmpty\n4. Count\n";
        scanf_s("%d", &choice1);
        switch(choice1)
        {
        case 1:
            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);

            break;
        case 2:
            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);

            q.dequeue();
            break;
        case 3:
            if (q.isEmpty()) {
                cout << "The queue is empty\n";
            }
            break;
        case 4:

            break;
        }
        break;
    case 4:
        cout << "\n1. Enqueue\n2. Dequeue\n3. IsEmpty\n4. Count\n";
        scanf_s("%d", &choice1);
        switch (choice1) {
        case 1:
            cout << "ADDING "<<q1.enQueue(10);
            cout << "\nADDING " << q1.enQueue(20);
            cout << "\nADDING " << q1.enQueue(30);
            cout << "\nQueue Front : " << (q1.front)->data << endl;
            cout << "Queue Rear : " << (q1.rear)->data;
            break;
        case 2:
            q1.enQueue(10);
            cout << "\nADDING " << q1.enQueue(10);
            q1.enQueue(20);
            cout << "\nADDING " << q1.enQueue(20);
            q1.enQueue(30);
            cout << "\nADDING " << q1.enQueue(30);
            q1.deQueue();
            cout << "\nDELETED " << q1.deQueue();
            break;
        case 3:
            if (q1.QIsEmpty()) {
                cout << "The queue is empty\n";
            }
            break;
        case 4:
            q1.enQueue(10);
            cout << "\nADDED " << q1.enQueue(10);
            q1.enQueue(20);
            cout << "\nADDED " << q1.enQueue(20);
            q1.enQueue(30);
            cout << "\nADDED " << q1.enQueue(30);
            q1.deQueue();
            q1.enQueue(40);
            cout << "\nADDED " << q1.enQueue(40);
            cout << "\nQueue Front : " << (q1.front)->data << endl;
            cout << "Queue Rear : " << (q1.rear)->data;
            break;
        }
        break;
    case 5:
        cout << "\n1. Enqueue\n2. Dequeue\n3. IsEmpty\n4. Count\n";
        scanf_s("%d", &choice1);
        switch (choice1) {
        case 1:
            enQueue(cq, 14);
            enQueue(cq, 22);
            enQueue(cq, 6);
            displayQueue(cq);
            break;
        case 2:
            enQueue(cq, 14);
            enQueue(cq, 22);
            enQueue(cq, 6);
            displayQueue(cq);
            printf("\nDeleted value = %d", deQueue(cq));
            printf("\nDeleted value = %d",deQueue(cq));
            displayQueue(cq);
            break;
        case 3:
            CQIsEmpty(cq);
            break;
        case 4:
            enQueue(cq, 14);
            enQueue(cq, 22);
            enQueue(cq, 6);

            // Display elements present in Circular Queue
            displayQueue(cq);

            // Deleting elements from Circular Queue
            printf("\nDeleted value = %d", deQueue(cq));
            printf("\nDeleted value = %d", deQueue(cq));

            // Remaining elements in Circular Queue
            displayQueue(cq);

            enQueue(cq, 9);
            enQueue(cq, 20);
            displayQueue(cq);
            break;
        }
        break;
    case 6:
        exit(0);
        break;
    }

}

