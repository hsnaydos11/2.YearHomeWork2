// Problem-3Console.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "../Problem-3/Header.h"
#include <iostream>
#include <cmath>
#include <stack>
#include <string>
#include "../Problem-3/InfixLibrary.cpp"
using namespace std;

int main(){
	int choice;
	printf("*****MENU*****\n1. Evaluate Infix\n2. Validate Infix\n3. InfixToPostfixConversion\n");
	scanf_s("%d",&choice);
	switch (choice)
	{
	case 1:
		cout << evaluate("100 * ( 2 + 12 ) / ( 14 *5 )");
		break;
	case 2:

		break;
	case 3:
		string infix_exp, postfix_exp;
		infix_exp = "(1+5)*(5%(10*10))";
		stack <char> stack;
		cout << "INFIX EXPRESSION: " << infix_exp << endl;
		postfix_exp = InfixToPostfix(stack, infix_exp);
		cout << endl << "POSTFIX EXPRESSION: " << postfix_exp;
		break;
	}
}

