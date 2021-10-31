#pragma once
#include <stdlib.h>
#include <iostream>
#include<stdio.h>
#include<conio.h>
#define MAX 1000
#define _CRT_SECURE_NO_WARNINGS
#define SIZE 10

using namespace std;
//********STACK ARRAY BASED********
class Stack {
    int top;
public:
    int a[MAX]; // Maximum size of Stack
    Stack() { top = -1; }
    bool Arraypush(int x);
    int Arraypop();
    int Arraytop();
    bool ArrayisEmpty();
};
bool Arraypush(int x);
int Arraypop();
int Arraytop();
bool ArrayisEmpty();

//*******STACK POINTER BASED*******
class StackNode {
public:
    int data;
    StackNode* next;
};
StackNode* newNode(int data);
int PointerisEmpty(StackNode* root);
int Pointerpush(StackNode** root, int data);
int Pointerpop(StackNode** root);
int Pointerpeek(StackNode* root);

//**********QUEUE ARRAY BASED********
class queue
{
    int* arr;       // array to store queue elements
    int capacity;   // maximum capacity of the queue
    int front;      // front points to the front element in the queue (if any)
    int rear;       // rear points to the last element in the queue
    int count;      // current size of the queue

public:
    queue(int size = SIZE);     // constructor
    ~queue();                   // destructor

    int dequeue();
    int enqueue(int x);
    int peek();
    int size();
    bool isEmpty();
    bool isFull();
};

//*********QUEUE SINGLE LINKED LIST*********
struct QNode {
    int data;
    QNode* next;
    QNode(int d)
    {
        data = d;
        next = NULL;
    }
};
//********QUEUE CIRCULAR LINKED LIST******
struct CNode {
    int data;
    struct CNode* link;
};
struct CircularQueue {
    struct CNode* front, * rear;
};
int enQueue(CircularQueue* q, int value);
int deQueue(CircularQueue* q);
int displayQueue(struct CircularQueue* q);
int CQIsEmpty(CircularQueue* q);

