#include <iostream>
#include <string>
#include <vector>
#include <array>

using namespace std;

class MinimumWindowSubstring
{
private:

	vector<vector<string>> testCases{
		{"ADOBECODEBANC", "ABC"}
	};

	vector<string> getInput(int index)
	{
		return testCases[index];
	}

	string getMinimumWindowSubstring(string inputString, string subStringToFind)
	{
		string minimumSubstring = "";
		
		if (subStringToFind.size() > inputString.size())
		{
			return minimumSubstring;
		}
		else
		{
			int m = subStringToFind.size();
			int n = inputString.size();
			// int indexArray[m][n];
			array<array<int, 10>, 20> indexArray;
			for (int i = 0; i < subStringToFind.size(); i++)
			{
				for (int j = 0; j < inputString.size(); j++)
				{

				}
			}
		}
		return minimumSubstring;
	}

public:
	int execute()
	{
		MinimumWindowSubstring data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<string> testCase = data.getInput(i);
			cout << data.getMinimumWindowSubstring(testCase[0], testCase[1]);
		}
		return 0;
	}
};