#include <vector>
#include <iostream>
#include <string>

using namespace std;

class FindMaximumNumber
{
private:

	vector<int> testCases{
		5555,
		-5555,
		1234,
		-1234,
		0,
		556,
		-556
	};

	int getTestCase(int idx)
	{
		return testCases[idx];
	}

	int findMaximumNumber(int number, int digit)
	{
		int numberOfDigits = number == 0 ? 0 : floor(log10(abs(number))) + 1;
		string numberAsString = to_string(number);
		bool negative = number < 0 ? true : false;
		int outputNumber = 0;

		if (negative)
		{
			int i = 1;
			for (; i <= numberOfDigits; i++)
			{
				int currentDigit = numberAsString[i] - 48;
				if (digit <= currentDigit)
				{
					string maxNumberAsString = numberAsString.insert(i, to_string(digit));
					if (stoi(maxNumberAsString) > INTMAX_MAX)
					{
						return -1;
					}
					else
					{
						outputNumber = stoi(maxNumberAsString);
						break;
					}
				}
			}
			if ((i - 1) == numberOfDigits)
			{
				string maxNumberAsString = numberAsString.insert(i, to_string(digit));
				if (stoi(maxNumberAsString) > INTMAX_MAX)
				{
					return -1;
				}
				else
				{
					outputNumber = stoi(maxNumberAsString);
				}
			}
		}
		else
		{
			int i = 0;
			for (; i < numberOfDigits; i++)
			{
				int currentDigit = numberAsString[i] - 48;
				if (digit >= currentDigit)
				{
					string maxNumberAsString = numberAsString.insert(i, to_string(digit));
					if (stoi(maxNumberAsString) > INT_MAX)
					{
						return -1;
					}
					else
					{
						outputNumber = stoi(maxNumberAsString);
						break;
					}
				}
				if ((i + 1) == numberOfDigits)
				{
					string maxNumberAsString = numberAsString.insert(i + 1, to_string(digit));
					if (stoi(maxNumberAsString) > INTMAX_MAX)
					{
						return -1;
					}
					else
					{
						outputNumber = stoi(maxNumberAsString);
					}
				}
			}
		}

		return outputNumber;
	}

public:
	int execute()
	{
		FindMaximumNumber data;
		int numberOfTestCases = data.testCases.size();
		int input;
		int output;
		int digit = 4;

		for (int i = 0; i < numberOfTestCases; i++)
		{
			input = data.getTestCase(i);
			output = data.findMaximumNumber(input, digit);
			cout << "Test Case: " << i << ", Input: " << input << ", Output: " << output << endl;
		}

		return 0;
	}
};