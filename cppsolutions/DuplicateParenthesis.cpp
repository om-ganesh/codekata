#include <iostream>
#include <stack>
#include <vector>
#include <string>

using namespace std;

class DuplicateParenthesis
{
private:

	vector<string> testCases
	{
		"(a+b)+((c+d))", // YES
		"((a+b)+(c+d))", // NO
	};

	string getInputExpression(int index)
	{
		return testCases[index];
	}

	bool hasDuplicateParenthesis(string expression)
	{
		stack<char> resultStack;

		for (int i = 0; i < expression.size(); i++)
		{
			char currentCharacter = expression[i];
			if (currentCharacter != ')')
			{
				resultStack.push(currentCharacter);
			}
			else
			{
				char topCharacterOfStack = resultStack.top();
				resultStack.pop();
				int count = 0;
				while (topCharacterOfStack != '(')
				{
					count++;
					topCharacterOfStack = resultStack.top();
					resultStack.pop();
				}
				if (count < 1)
				{
					return true;
				}
			}
			
		}
		return false;
	}

public:

	int execute()
	{
		DuplicateParenthesis data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testExpression = data.getInputExpression(i);
			if (data.hasDuplicateParenthesis(testExpression))
				cout << "YES" << endl;
			else
				cout << "NO" << endl;
		}
		return 0;
	}
};