#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class LongestPalindromeInArray
{
private:
	vector<vector<int>> testCases
	{
		{1, 54545, 232, 999991},
		{1, 5, 2, 3, 4, 50}
	};

	vector<int> getTestCase(int index)
	{
		return testCases[index];
	}

	bool isPalindrome(int number)
	{
		int reverse = 0;
		int orgNumber = number;
		while (number)
		{
			int digit = number % 10;
			number = number / 10;
			reverse = reverse * 10 + digit;
		}

		if (orgNumber == reverse)
			return true;
		else
			return false;
	}

	int getLargestPalindrome(vector<int> input)
	{
		sort(input.begin(), input.end());
		int length = input.size();
		int result = 0;

		for (int i = length - 1; i >= 0; i--)
		{
			if (isPalindrome(input[i]))
			{
				result = input[i];
				break;
			}
		}
		return result;
	}

public:
	int execute()
	{
		LongestPalindromeInArray data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getTestCase(i);
			cout << "Largest Palindrome: " << data.getLargestPalindrome(testCase) << endl;
		}
		return 0;
	}
};