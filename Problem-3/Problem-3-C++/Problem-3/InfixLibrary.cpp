#include "Header.h"

int precedence(char op) { //to find precedence of operators "+,-,*,/"
    if (op == '+' || op == '-')
        return 1;
    if (op == '*' || op == '/')
        return 2;
    return 0;
}
// Function to perform arithmetic operations.
int applyOp(int a, int b, char op) {
    switch (op) {
    case '+': return a + b;
    case '-': return a - b;
    case '*': return a * b;
    case '/': return a / b;
    }
}
int prec(char c) {  //to find precedence of operators "+,-,*,/"
    if (c == '^')
        return 3;
    else if (c == '/' || c == '*')
        return 2;
    else if (c == '+' || c == '-')
        return 1;
    else
        return -1;
}
bool isOperator(char c) {
    if (c == '+' || c == '-' || c == '/' || c == '^') 
    {
        return true;
    }
    else
    {
        return false;
    }
}
int evaluate(string tokens) {
    int i;

    stack <int> values;  //to store integer data

    stack <char> ops; //to store operator

    for (i = 0; i < tokens.length(); i++) {

        // Current token is a whitespace,
        // skip it.
        if (tokens[i] == ' ')  //to skip because of empty token
            continue;

        else if (tokens[i] == '(') { //current token is opening brace and add to ops
            ops.push(tokens[i]);
        }

        else if (isdigit(tokens[i])) {  //current token have a number, add to stack for number
            int val = 0;

            // There may be more than one
            // digits in number.
            while (i < tokens.length() &&
                isdigit(tokens[i]))
            {
                val = (val * 10) + (tokens[i] - '0');
                i++;
            }

            values.push(val);

            i--; //where the loop increases i and we decrease i here to complete the offset.
        }

        // Closing brace encountered, solve entire brace.
        else if (tokens[i] == ')')
        {
            while (!ops.empty() && ops.top() != '(')
            {
                int val2 = values.top();
                values.pop();

                int val1 = values.top();
                values.pop();

                char op = ops.top();
                ops.pop();

                values.push(applyOp(val1, val2, op));
            }

            if (!ops.empty())  //brace is opened by pop
                ops.pop();
        }

        // Current token is an operator.
        else
        {
            // While top of 'ops' has same or greater
            // precedence to current token, which
            // is an operator. Apply operator on top
            // of 'ops' to top two elements in values stack.
            while (!ops.empty() && precedence(ops.top())
                >= precedence(tokens[i])) {
                int val2 = values.top();
                values.pop();

                int val1 = values.top();
                values.pop();

                char op = ops.top();
                ops.pop();

                values.push(applyOp(val1, val2, op));
            }

            // Push current token to 'ops'.
            ops.push(tokens[i]);
        }
    }

    //All expressions are decomposed into their values.To continue the proceedings
    while (!ops.empty()) {
        int val2 = values.top();
        values.pop();

        int val1 = values.top();
        values.pop();

        char op = ops.top();
        ops.pop();

        values.push(applyOp(val1, val2, op));
    }

    // Top of 'values' contains result, return it.
    return values.top();
}
string InfixToPostfix(stack<char> s, string infix) //to cpnvert infix to postfix expression
{
    string postfix;
    for (int i = 0; i < infix.length(); i++)
    {
        if ((infix[i] >= 'a' && infix[i] <= 'z') || (infix[i] >= 'A' && infix[i] <= 'Z') || (infix[i] >= '0' && infix[i] <= '9'))
        {
            postfix += infix[i];
        }
        else if (infix[i] == '(')  //it will process when it sees "("
        {
            s.push(infix[i]);
        }
        else if (infix[i] == ')') //it will ends when it sees ")" until see "("
        {
            while ((s.top() != '(') && (!s.empty()))
            {
                char temp = s.top();
                postfix += temp;
                s.pop();
            }
            if (s.top() == '(')
            {
                s.pop();
            }
        }
        else if (isOperator(infix[i])) //first character is scanned, add it output string
        {
            if (s.empty())
            {
                s.push(infix[i]);
            }
            else
            {
                if (precedence(infix[i]) > precedence(s.top()))
                {
                    s.push(infix[i]);
                }
                else if ((precedence(infix[i]) == precedence(s.top())) && (infix[i] == '^'))
                {
                    s.push(infix[i]);
                }
                else
                {
                    while ((!s.empty()) && (precedence(infix[i]) <= precedence(s.top()))) //if an operator is scanned
                    {
                        postfix += s.top();
                        s.pop();
                    }
                    s.push(infix[i]);
                }
            }
        }
    }
    //pop all current items
    while (!s.empty())
    {
        postfix += s.top();
        s.pop();
    }

    return postfix;
}



    