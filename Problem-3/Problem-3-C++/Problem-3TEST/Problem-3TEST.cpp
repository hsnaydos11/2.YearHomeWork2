#include "pch.h"
#include "CppUnitTest.h"
#include "../Problem-3/InfixLibrary.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace Problem3TEST
{
	TEST_CLASS(EVALUATE)
	{
	public:
		
		TEST_METHOD(GoodCase)
		{
			evaluate("100 * ( 2 + 12 ) / ( 14 *5 )");
			bool result = evaluate("100 * ( 2 + 12 ) / ( 14 *5 )");
			Assert::AreEqual(true, result);
		}
		TEST_METHOD(BadCase)
		{
			evaluate("100 * ( 2 + 12 ) / ( 14 *5 )");
			bool result = evaluate("100 * ( 2 + 12 ) / ( 14 *5 )");
			Assert::AreNotEqual(false, result);
		}
		TEST_METHOD(UglyCase)
		{
			evaluate("100 * ( 2 + 12 ) / ( 14 *5 )");
			bool result = evaluate("100 * ( 2 + 12 ) / ( 14 *5 )");
			Assert::AreNotSame(false, result);
		}
	};
	TEST_CLASS(INFIXTOPOSTFIX)
	{
	public:
		TEST_METHOD(GoodCase)
		{
			string infix_exp, postfix_exp;
			infix_exp = "(1+5)*(5%(10*10))";
			stack <char> stack;
			postfix_exp = InfixToPostfix(stack, infix_exp);

			string result = InfixToPostfix(stack, infix_exp);

			Assert::AreEqual(postfix_exp, result);
		}
		TEST_METHOD(BadCase)
		{
			string infix_exp, postfix_exp;
			infix_exp = "(1+5)*(5%(10*10))";
			stack <char> stack;
			postfix_exp = InfixToPostfix(stack, infix_exp);

			string result = InfixToPostfix(stack, infix_exp);

			Assert::AreNotEqual(postfix_exp, result);
		}
		TEST_METHOD(UglyCase)
		{
			string infix_exp, postfix_exp;
			infix_exp = "(1+5)*(5%(10*10))";
			stack <char> stack;
			postfix_exp = InfixToPostfix(stack, infix_exp);

			string result = InfixToPostfix(stack, infix_exp);

			Assert::AreNotSame(postfix_exp, result);
		}
	};
}
