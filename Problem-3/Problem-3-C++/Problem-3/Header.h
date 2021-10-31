#pragma once
#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <stack>
#include <cmath>

using namespace std;
int precedence(char op);
int applyOp(int a, int b, char op);
int prec(char c);
bool isOperator(char c);
int evaluate(string tokens);
string InfixToPostfix(stack<char> s, string infix);
