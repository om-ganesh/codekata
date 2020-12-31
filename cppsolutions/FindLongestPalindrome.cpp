#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

class FindLongestPalindrome
{
private:

	vector<string> testCases{
		"ABCVFAAFXY",
		"aabbaa"
	};

	string getInput(int index)
	{
		return testCases[index];
	}

	bool isPalindrome(string s)
	{
		bool result = false;
		string str = s;
		reverse(s.begin(), s.end());
		if (s == str)
			result = true;
		return result;
	}

	string subString(string s, int from, int to)
	{
		string subStr;
		for (int i = from; i <= to; i++)
		{
			// subStr[i] = s[i];
			subStr.push_back(s[i]);
		}
		return subStr;
	}

	string findMaxPalindrome(string inputString)
	{
		if (isPalindrome(inputString))
		{
			return inputString;
		}
		
		int leftIndex = 0; 
		int rightIndex = inputString.size() - 1;

		// Mod: 2
		while (leftIndex != rightIndex)
		{
			// string leftSubString = inputString.substr(leftIndex, length);
			// string rightSubString = inputString.substr(leftIndex+1, rightIndex+1);
			// Mod: 1
			string leftSubString = subString(inputString, leftIndex, rightIndex-1);
			string rightSubString = subString(inputString, leftIndex+1, rightIndex);

			if (isPalindrome(leftSubString))
			{
				return leftSubString;
			}
			if (isPalindrome(rightSubString))
			{
				return rightSubString;
			}
			leftIndex++;
			rightIndex--;
		}
	}

public:

	int execute()
	{
		FindLongestPalindrome data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = getInput(i);
			cout << "TestCase # " << i << ": " << data.findMaxPalindrome(testCase) << endl;
		}
		return 0;
	}
};