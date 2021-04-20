#include <vector>
#include <string>
#include <iostream>

using namespace std;

class Rounders
{
private:
	vector<int> testCases
	{
		15,
		1234,
		1445,
		99
	};

	int getTestCase(int index)
	{
		return testCases[index];
	}

	int rounders(int n)
	{
		int length = log10(n) + 1;
		string newNum;
		int carry = 0;
		int digit;
		do {
			digit = n % 10;
			n = n / 10;
			length = log10(n) + 1;

			digit = digit + carry;
			newNum.push_back('0');
			if (digit >= 5)
			{
				carry = 1;
			}
			else
			{
				carry = 0;
			}

		} while (length > 1);

		digit = n % 10 + carry;
		if (digit <= 9)
		{
			newNum.push_back(digit + 48);
		}
		else
		{
			newNum.push_back(0 + 48);
			newNum.push_back(1 + 48);
		}
		reverse(newNum.begin(), newNum.end());
		return stoi(newNum);
	}

public:
	int execute()
	{
		Rounders data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			int testCase = data.getTestCase(i);
			cout << data.rounders(testCase) << endl;
		}
		return 0;
	}
};