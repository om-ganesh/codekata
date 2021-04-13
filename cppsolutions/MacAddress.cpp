#include <iostream>
#include <string>
#include <vector>

using namespace std;

class MacAddress
{
private:
	vector<string> testCases
	{
		"FF-FF-FF-FF-FF-FF",
		"00-1B-63-84-45-E6",
		"Z1-1B-63-84-45-E6"
	};

	string getTestCase(int index)
	{
		return testCases[index];
	}

	bool isHexa(char c)
	{
		if (c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F' || c == 'a' || c == 'b' || c == 'c' || c == 'd' || c == 'e' || c == 'f')
		{
			return true;
		}
		return false;
	}

	bool isMAC48Address(string inputString) {

		if (inputString.length() != 17)
		{
			return false;
		}


		for (int i = 0; i < inputString.length(); i++)
		{
			if (i == 2 || i == 5 || i == 8 || i == 11 || i == 14)
			{
				if (inputString[i] != '-')
				{
					return false;
				}
			}
			else {
				if (!isdigit(inputString[i]) && !isHexa(inputString[i]))
				{
					return false;
				}
			}
		}
		return true;
	}

public:

	int execute()
	{
		MacAddress data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = data.getTestCase(i);
			cout << isMAC48Address(testCase) << endl;
		}

		return 0;
	}
};