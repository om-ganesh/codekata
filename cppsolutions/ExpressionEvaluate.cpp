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

	string getInputData(int n)
	{
		vector<string> testCases{
			"3",
			"(+10  20)",
			"(+1 10 (*2 3) 20)",
			"(+1 10",
			")* 2 3("
			};

		return testCases[n];
	}

public:
	int evaluateExpression(string input)
	{
		int res = 0;
		int length = input.length();

		for (int i = 0; i < length; i++)
		{
			if (input[i] != '(' && length == 1)
			{
				res = stoi(&input[i]);
					break;
			}
			else if (input[i] != '(' && length > 1)
			{
				res = stoi(&input[i]);
					break;
			}
			else if (input[i] == ')')
			{
				res = -1;
				break;
			}
			else
			{
				char space = ' ';

			}
		}
		return res;
	}

	int execute(void)
	{
		ExpressionEvaluate data;
		int totalTestCases = 4;
		int result;
		for (int i = 0; i < totalTestCases; i++)
		{
			data.inputExpression = getInputData(i);
			result = data.evaluateExpression(data.inputExpression);
			cout << " - 1 means invalid " << endl;
			cout << result << " ";
		}

		return 0;
	}

};

