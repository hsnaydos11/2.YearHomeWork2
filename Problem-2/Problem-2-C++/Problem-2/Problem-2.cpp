#include "Header.h"
//********STACK ARRAY BASED********
bool Stack::Arraypush(int x)    //to insert into stack
{
    if (top >= (MAX - 1)) { //if there is nothing to stack, to encounter 
        return false;
    }
    else {
        a[++top] = x;   //to insert into stack
        cout << x << " pushed into stack\n";
        return true;
    }
}
int Stack::Arraypop()  //to delete item in stack
{
    if (top < 0) {  //if there is no item in stack
        return 0;
    }
    else {    //to delete top item in stack
        int x = a[top--];
        return x;  //and return x item;
    }
}
int Stack::Arraytop()
{
    if (top < 0) {  //if there is nothing in stack, to write stack is empty.
        cout << "Stack is Empty";
        return 0;
    }
    else {
        int x = a[top];  //to find the highest item in stack
        return x;
    }
}
bool Stack::ArrayisEmpty() //if there is no item in stack, to determine
{
    return (top < 0);
}
//*******STACK POINTER BASED*******
StackNode* newNode(int data)   // A structure to represent a stack
{
    StackNode* stackNode = new StackNode();
    stackNode->data = data;
    stackNode->next = NULL;
    return stackNode;
}
int PointerisEmpty(StackNode* root)  //if struct is empty, to return root
{
    return !root;
}
int Pointerpush(StackNode** root, int data)  //to insert items in stack pointer based
{
    StackNode* stackNode = newNode(data);
    stackNode->next = *root;
    *root = stackNode;
    cout << data << " pushed to stack\n";
    return data;
}
int Pointerpop(StackNode** root)  //to delete item in pointer based stack 
{
    if (PointerisEmpty(*root))  //if stack is empty, return int min 
        return INT_MIN;
    StackNode* temp = *root;   //first determine temporary node
    *root = (*root)->next;     //continue next item 
    int popped = temp->data;
    free(temp);    //last delete temporary node 

    return popped;
}
int Pointerpeek(StackNode* root)  //to determine the highest item in stack
{
    if (PointerisEmpty(root))  //if stack is empty, to indicate
        return INT_MIN;
    return root->data;
}

//*******QUEUE ARRAY BASED*******

// Constructor to initialize a queue
queue::queue(int size)
{
    arr = new int[size];
    capacity = size;
    front = 0;
    rear = -1;
    count = 0;
}

// Destructor to free memory allocated to the queue
queue::~queue() {
    delete[] arr;
}

// Utility function to dequeue the front element
int queue::dequeue()
{
    // check for queue underflow
    if (isEmpty())
    {
        cout << "Underflow\nProgram Terminated\n";
        exit(EXIT_FAILURE);
    }

    cout << "Deleting " << arr[front] << endl;  //to delete front element in queue

    front = (front + 1) % capacity;
    count--;
    return 0;
}

// Utility function to add an item to the queue
int queue::enqueue(int item)
{
    // check for queue overflow
    if (isFull())
    {
        cout << "Overflow\nProgram Terminated\n";
        exit(EXIT_FAILURE);
    }

    cout << "ADDING " << item << endl; //to add item in queue

    rear = (rear + 1) % capacity;
    arr[rear] = item;
    count++;
    return item;
}
int queue::peek()  //to find the highest item in queue
{
    if (isEmpty())
    {
        cout << "Underflow\nProgram Terminated\n";
        exit(EXIT_FAILURE);
    }
    return arr[front];
}
int queue::size() {
    return count;
}
// Utility function to check if the queue is empty or not
bool queue::isEmpty() {
    return (size() == 0);
}
// Utility function to check if the queue is full or not
bool queue::isFull() {
    return (size() == capacity);
}

//*********QUEUE LINKED LIST*********
struct Queue {
    QNode* front, * rear;
    Queue()
    {
        front = rear = NULL;
    }
    int enQueue(int x)  //to item in queue
    {
        // Create a new node
        QNode* temp = new QNode(x);

        if (rear == NULL) {  //if queue is empty, new node is front and rear both
            front = rear = temp;
            return 0;
        }

        // Add the new node at the end of queue and change rear
        rear->next = temp;
        rear = temp;
        return x;
    }

    int deQueue() //to delete item in queue
    {
        // If queue is empty, return NULL.
        if (front == NULL)
            return 0;

        // Store previous front and
        // move front one node ahead
        QNode* temp = front;
        front = front->next;

        // If front becomes NULL, then
        // change rear also as NULL
        if (front == NULL)
            rear = NULL;

        delete (temp); //to delete temporary node from queue
        return 0;
    }
    bool QIsEmpty() {  //if queue is empty , to print
        cout << " ";
        return(front == 0);
    }
};
//*********QUEUE CIRCULAR LIST*******
int enQueue(CircularQueue* q, int value) //to add item in queue
{
    struct CNode* temp = new CNode;
    temp->data = value;
    if (q->front == NULL) //if there is nothing in queue, to add item 
        q->front = temp;
    else
        q->rear->link = temp;

    q->rear = temp;
    q->rear->link = q->front;
    return value;
}
// Function to delete element from Circular Queue
int deQueue(CircularQueue* q)
{
    if (q->front == NULL) {
        printf("Queue is empty");
        return INT_MIN;
    }

    // If this is the last node to be deleted
    int value; // value will be deleted
    if (q->front == q->rear) {
        value = q->front->data;
        free(q->front);
        q->front = NULL;
        q->rear = NULL;
    }
    else // There are more than one nodes
    {
        struct CNode* temp = q->front;
        value = temp->data;
        q->front = q->front->link;
        q->rear->link = q->front;
        free(temp);
    }

    return value;
}
int displayQueue(struct CircularQueue* q) //to display items of queue
{
    struct CNode* temp = q->front;
    printf("\nElements in Circular Queue are: ");
    while (temp->link != q->front) {
        printf("%d ", temp->data);
        temp = temp->link;
    }
    printf("%d", temp->data);
    return 0;
}
int CQIsEmpty(CircularQueue *q) {  //if there is nothing in queue, to show items of queue
    if (q->front == NULL) {   
        printf("Queue is empty");
        return INT_MIN;
    }
    return 0;
}

