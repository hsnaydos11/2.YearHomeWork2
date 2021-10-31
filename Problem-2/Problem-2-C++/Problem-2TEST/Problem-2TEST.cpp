#include "pch.h"
#include "CppUnitTest.h"
#include "..\Problem-2\Header.h"
#include "../Problem-2/Problem-2.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace Problem2TEST
{
	//*********STACK ARRAY BASED********
	TEST_CLASS(STACKARRPUSH)
	{
	public:
		
		TEST_METHOD(GoodCase)
		{
			class Stack s;
			s.Arraypush(10);
			s.Arraypush(20);
			s.Arraypush(30);
			bool result = s.Arraypush(20);
			Assert::AreEqual(true, result);
		}
		TEST_METHOD(BadCase)
		{
			class Stack s;
			s.Arraypush(10);
			s.Arraypush(20);
			s.Arraypush(30);
			bool result = s.Arraypush(10);
			Assert::AreNotEqual(false, result);
		}
		TEST_METHOD(UglyCase)
		{
			class Stack s;
			s.Arraypush(10);
			s.Arraypush(20);
			s.Arraypush(30);
			bool result = s.Arraypush(10);
			Assert::AreNotSame(false, result);
		}
	};
	TEST_CLASS(STACKARRPOP) 
	{
	public:
		TEST_METHOD(GoodCase) 
		{
			class Stack item, item1, item2;
			item.Arraypush(10);
			item1.Arraypush(20);
			item2.Arraypush(30);
			int result = item.Arraypop();
			Assert::AreEqual(result, 10);
		}
		TEST_METHOD(BadCase)
		{
			class Stack item, item1, item2;
			item.Arraypush(10);
			item1.Arraypush(20);
			item2.Arraypush(30);
			int result = item1.Arraypop();
			Assert::AreNotEqual(result, 10);
		}
		TEST_METHOD(UglyCase)
		{
			class Stack item, item1, item2;
			item.Arraypush(10);
			item1.Arraypush(20);
			item2.Arraypush(30);
			int result = item2.Arraypop();
			Assert::AreNotSame(result, 20);
		}
	};
	TEST_CLASS(STACKARRTOP) 
	{
	public:
		TEST_METHOD(GoodCase) 
		{
			class Stack item, item1, item2;
			item.Arraypush(10);
			item1.Arraypush(20);
			item2.Arraypush(30);
			int result = item.Arraytop();
			Assert::AreEqual(10,result);
		}
		TEST_METHOD(BadCase)
		{
			class Stack item, item1, item2;
			item.Arraypush(10);
			item1.Arraypush(20);
			item2.Arraypush(30);
			int result = item1.Arraytop();
			Assert::AreNotEqual(result, 10);
		}
		TEST_METHOD(UglyCase)
		{
			class Stack item, item1, item2;
			item.Arraypush(10);
			item1.Arraypush(20);
			item2.Arraypush(30);
			int result = item2.Arraytop();
			Assert::AreNotSame(result, 30);
		}
	};
	//********STACK POINTER BASE********
	TEST_CLASS(STACKPOINTERPUSH)
	{
	public:
		TEST_METHOD(GoodCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			int result = Pointerpush(&root, 10);
			Assert::AreEqual(result,10);
		}
		TEST_METHOD(BadCase) 
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			int result = Pointerpush(&root1, 20);
			Assert::AreNotEqual(result, 10);
		}
		TEST_METHOD(UglyCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			int result = Pointerpush(&root, 30);
			Assert::AreNotSame(result, 30);
		}
	};
	TEST_CLASS(STACKPOINTERPOP)
	{
	public:
		TEST_METHOD(GoodCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			bool result = Pointerpop(&root);
			Assert::AreEqual(true, result);
		}
		TEST_METHOD(BadCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			bool result = Pointerpop(&root1);
			Assert::AreNotEqual(false, result);
		}
		TEST_METHOD(UglyCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			bool result = Pointerpop(&root2);
			Assert::AreNotSame(false, result);
		}
	};
	TEST_CLASS(STACKPOINTERTOP)
	{
	public:
		TEST_METHOD(GoodCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			int result = Pointerpeek(root);
			Assert::AreEqual(result, 10);
		}
		TEST_METHOD(BadCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			int result = Pointerpeek(root);
			Assert::AreNotEqual(result, 20);
		}
		TEST_METHOD(UglyCase)
		{
			StackNode* root = NULL;
			StackNode* root1 = NULL;
			StackNode* root2 = NULL;

			Pointerpush(&root, 10);
			Pointerpush(&root1, 20);
			Pointerpush(&root2, 30);
			int result = Pointerpeek(root);
			Assert::AreNotSame(result, 20);
		}
	};
	//********QUEUE ARRAY BASED**********	
	TEST_CLASS(QUEUEARRAYENQUEUE) {
	public:
		TEST_METHOD(GoodCase) {
			Queue q1, q2, q3;
			q1.enQueue(10);
			q2.enQueue(20);
			int result = q1.enQueue(1);
			Assert::AreEqual(1,result);
		}
		TEST_METHOD(BadCase) {
			Queue q1, q2, q3;
			q1.enQueue(1);
			q2.enQueue(2);
			q3.enQueue(3);

			int result = q2.enQueue(2);
			Assert::AreNotEqual(result, 1);
		}
		TEST_METHOD(UglyCase) {
			Queue q1, q2, q3;
			q1.enQueue(1);
			q2.enQueue(2);
			q3.enQueue(3);
			int result = q3.enQueue(3);
			Assert::AreNotSame(result,2);
		}
	};
	TEST_CLASS(QUEUEARRAYDEQUEUE) {
	public:
		TEST_METHOD(GoodCase) {
			queue q;
			q.enqueue(1);
			q.enqueue(2);
			q.enqueue(3);

			bool result = q.dequeue();
			Assert::AreEqual(false,result);
		}
		TEST_METHOD(BadCase) {
			queue q;
			q.enqueue(1);
			q.enqueue(2);
			q.enqueue(3);

			int result = q.dequeue();
			Assert::AreNotEqual(result, 3);
		}
		TEST_METHOD(UglyCase) {
			queue q;
			q.enqueue(1);
			q.enqueue(2);
			q.enqueue(3);

			int result = q.dequeue();
			Assert::AreNotSame(result, 2);
		}
	};
	TEST_CLASS(QUEUEARRAYEMPTY) {
	public:
		TEST_METHOD(GoodCase) {
			queue q;
			q.isEmpty();
			bool result = q.isEmpty();
			Assert::AreEqual(true, result);
		}
		TEST_METHOD(BadCase) {
			queue q;
			q.isEmpty();
			bool result = q.isEmpty();
			Assert::AreNotEqual(false, result);
		}
		TEST_METHOD(UglyCase) {
			queue q;
			q.isEmpty();
			bool result = q.isEmpty();
			Assert::AreNotSame(true, result);
		}
	};
	//********QUEUE SINGLE BASED********
	TEST_CLASS(QUEUESINGLEENQUEUE) {
	public:
		TEST_METHOD(GoodCase) {
			Queue q1, q2, q3;
			q1.enQueue(10);
			q2.enQueue(20);
			q3.enQueue(30);
			int result = q1.enQueue(10);
			Assert::AreEqual(result, 10);
		}
		TEST_METHOD(BadCase) {
			Queue q1, q2, q3;
			q1.enQueue(10);
			q2.enQueue(20);
			q3.enQueue(30);
			int result = q2.enQueue(20);
			Assert::AreNotEqual(result, 10);
		}
		TEST_METHOD(UglyCase) {
			Queue q1, q2, q3;
			q1.enQueue(10);
			q2.enQueue(20);
			q3.enQueue(30);
			int result = q3.enQueue(30);
			Assert::AreNotSame(result, 10);
		}
	};
	TEST_CLASS(QUEUESINGLEDEQUEUE) {
	public:
		TEST_METHOD(GoodCase) {
			Queue q1, q2, q3;
			q1.enQueue(10);
			q2.enQueue(20);
			q3.enQueue(30);
			q1.deQueue();
			bool result = q1.deQueue();
			Assert::AreNotSame(true, result);
		}
		TEST_METHOD(BadCase) {
			Queue q1, q2, q3;
			q1.enQueue(10);
			q2.enQueue(20);
			q3.enQueue(30);
			q2.deQueue();
			bool result = q2.deQueue();
			Assert::AreNotEqual(true, result);
		}
		TEST_METHOD(UglyCase) {
			Queue q1, q2, q3;
			q1.enQueue(10);
			q2.enQueue(20);
			q3.enQueue(30);
			q3.deQueue();
			bool result = q3.deQueue();
			Assert::AreNotSame(false, result);
		}
	};
	TEST_CLASS(QUEUESINGLEEMPTY) {
	public:
		TEST_METHOD(GoodCase) {
			Queue q, q1, q2;
			q.QIsEmpty();
			bool result = q.QIsEmpty();
			Assert::AreEqual(true,result);
		}
		TEST_METHOD(BadCase) {
			Queue q, q1, q2;
			q1.QIsEmpty();
			bool result = q1.QIsEmpty();
			Assert::AreNotEqual(false, result);
		}
		TEST_METHOD(UglyCase) {
			Queue q, q1, q2;
			q2.QIsEmpty();
			bool result = q2.QIsEmpty();
			Assert::AreNotSame(false, result);
		}
	};
	//********QUEUE CIRCULAR BASED******
	TEST_CLASS(QUEUECIRCULARENQUEUE) {
	public:
		TEST_METHOD(GoodCase) {
			CircularQueue* cq = new CircularQueue;

			enQueue(cq, 14);
			enQueue(cq, 22);
			enQueue(cq, 6);
			bool result = enQueue(cq,14);
			Assert::AreEqual(true,result);
		}
		TEST_METHOD(BadCase) {
			CircularQueue* cq = new CircularQueue;

			enQueue(cq, 14);
			enQueue(cq, 22);
			enQueue(cq, 6);
			bool result = enQueue(cq,22);
			Assert::AreNotEqual(false,result);
		}
		TEST_METHOD(UglyCase) {
			CircularQueue* cq = new CircularQueue;
			enQueue(cq, 14);
			enQueue(cq, 22);
			enQueue(cq, 6);
			bool result = enQueue(cq, 6);
			Assert::AreNotSame(false,result);
		}
	};
	TEST_CLASS(QUEUECIRCULARDEQUEUE) {
		TEST_METHOD(GoodCase) {
			CircularQueue* cq = new CircularQueue;
			enQueue(cq, 14);
			enQueue(cq, 22);
			enQueue(cq, 6);
			int result = deQueue(cq);
			Assert::AreEqual(result, deQueue(cq));
		}
		TEST_METHOD(BadCase) {
			CircularQueue* cq = new CircularQueue;
			CircularQueue* cq1 = new CircularQueue;
			CircularQueue* cq2 = new CircularQueue;
			enQueue(cq, 14);
			enQueue(cq1, 22);
			enQueue(cq2, 6);
			deQueue(cq);
			bool result = deQueue(cq1);
			Assert::AreNotEqual(false, result);
		}
		TEST_METHOD(UglyCase) {
			CircularQueue* cq = new CircularQueue;
			CircularQueue* cq1 = new CircularQueue;
			CircularQueue* cq2 = new CircularQueue;
			enQueue(cq, 14);
			enQueue(cq1, 22);
			enQueue(cq2, 6);
			deQueue(cq);
			bool result = deQueue(cq2);
			Assert::AreNotSame(true, result);
		}
	};
}
