#include "iostream"
#include "string"
#include "vector"

using namespace std;

class StringReverse
{
private:

	vector<string> testCases
	{
		"Hello World",
		"Code Value"
	};

	string getTestCase(int index)
	{
		return testCases[index];
	}

	string reverseString(string input)
	{
		int length = input.length();
		string output;
		int j = 0;
		for (int i = length - 1; i >= 0; i--)
		{
			//output[j] = input[i];
			output.push_back(input[i]);
		}
		return output;
	}

public:
	int execute()
	{
		StringReverse data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = data.getTestCase(i);
			cout << data.reverseString(testCase) << endl;
		}

		return 0;
	}
};