//expr :: = int | '(' op expr + ')'
//op :: = '+' | '*'


#include<iostream>
#include<string>
#include<stack>
#include<vector>

using namespace std;

class ExpressionEvaluate
{

private:

	string inputExpression;

	vector<string> testCases{
			"3",
			"(+10 20)",
			"(+10 (*2 3))",
			"(+1 10",
			")*2 3(",
			"+5 (*2 3))"
	};

	string getInputData(int n)
	{
		return testCases[n];
	}

	stack<char> getStackForThisExpression(string expression)
	{
		stack<char> stackForExpression;
		int length = expression.size();

		for (int i = 0; i < length; i++)
		{
			stackForExpression.push(expression[i]);
		}

		return stackForExpression;
	}

public:
	int evaluateExpression(string input)
	{
		int res = 0;
		char spaceCharacter = ' ';
		int offSetToMakeThisCharADigit = 48;
		int number1, number2;
		stack<char> stackForExpression = getStackForThisExpression(input);
		stack<char> stackForClosingBrace;

		while (!stackForExpression.empty())
		{
			char currentChar = stackForExpression.top();
			stackForExpression.pop();
			
			if (currentChar == ')')
			{
				int decimal = 1;
				number1 = 0;
				number2 = 0;

				while (currentChar != '(')
				{
					currentChar = stackForExpression.empty() ? currentChar = '(' : stackForExpression.top();
					if (stackForExpression.empty())
					{
						currentChar = '(';
						res = -1;
					}
					else
					{
						currentChar = stackForExpression.top();
						stackForExpression.pop();
					}
					
					if (currentChar == spaceCharacter)
					{
						decimal = 1;
						number2 = number1;
						number1 = 0;
					}
					else if (currentChar == '+' || currentChar == '*')
					{
						res = currentChar == '+' ? (number1 + number2) : (number1 * number2);
					}
					else if (currentChar == ')')
					{
						stackForClosingBrace.push(currentChar);
					}
					else
					{
						number1 = number1 + (currentChar - offSetToMakeThisCharADigit) * decimal;
						decimal = decimal * 10;
					}
				}
			}
			else
			{
				res = -1;
			}
			if (!stackForClosingBrace.empty())
			{
				stackForExpression.push(res + offSetToMakeThisCharADigit);
				stackForExpression.push(stackForClosingBrace.top());
				stackForClosingBrace.pop();
				res = 0;
			}
		}

		return res;
	}

	int execute(void)
	{
		ExpressionEvaluate data;
		int totalTestCases = data.testCases.size();
		int result;

		for (int i = 0; i < totalTestCases; i++)
		{
			data.inputExpression = getInputData(i);
			result = data.evaluateExpression(data.inputExpression);
			cout << result << endl;
		}

		return 0;
	}

};

