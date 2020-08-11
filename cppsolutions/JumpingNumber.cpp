#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

class JumpingNumber
{
private:
	vector<int> allJumpingNumbersTillN;

	bool isJumping(int x)
	{
		bool returnValue = false;

		if (x >= 0 && x <= 9)
		{
			returnValue = true;
		}
		else
		{
			int rightDigit = x % 10;
			int quotient = x / 10;
			int diff = 0;
			int nextDigit;

			while (quotient > 0)
			{
				nextDigit = quotient % 10;
				diff = abs(nextDigit - rightDigit);
				if (diff > 1)
				{
					returnValue = false;
					break;
				}
				else if (diff == 1)
				{
					rightDigit = nextDigit;
					quotient = quotient / 10;
					returnValue = true;
				}
				else
				{
					returnValue = false;
					break;
				}
			}
		}
		
		return returnValue;
	}

	void findAllJumpingNumbersFromZeroToN(int n)
	{
		for (int i = 0; i < n; i++)
		{
			if (isJumping(i))
				allJumpingNumbersTillN.push_back(i);
		}
	}

	void printArray()
	{
		int length = allJumpingNumbersTillN.size();
		for (int i = 0; i < length; i++)
		{
			cout << allJumpingNumbersTillN[i] << " ";
		}
		cout << endl;
	}
public:
	int execute()
	{
		int n = 500;
		findAllJumpingNumbersFromZeroToN(n);
		printArray();

		return 0;
	}
};