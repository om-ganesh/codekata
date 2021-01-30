#include <iostream>
#include <vector>

using namespace std;

class ReverseInteger
{

private:
	vector<int> testCases
	{
		1234,
		4321,
		-2345,
		0,
		1000,
		-505
	};
	
	int getTestCase(int index)
	{
		return testCases[index];
	}

	int reverseInteger(int input)
	{
		bool negative = false;
		int reversed = 0;
		int base = 10;

		if (input < 0)
		{
			negative = true;
			input = input * -1;
		}

		if (input != 0)
		{
			while (input)
			{
				int currentDigit = input % base;
				input = input / base;

				reversed = reversed * base + currentDigit;
			}
			if (negative)
			{
				reversed = reversed * -1;
			}
		}

		return reversed;
	}

public:

	int execute()
	{
		ReverseInteger data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			int testCase = data.getTestCase(i);
			int reversed = data.reverseInteger(testCase);
			cout << "Reverse of " << testCase << " is " << reversed << endl;
		}
		return 0;
	}
};