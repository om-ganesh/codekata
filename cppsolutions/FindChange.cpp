#include <iostream>
#include <string>
#include <vector>
#include <cmath>

using namespace std;

class FindChange
{
private:

	vector<string> testCases
	{
		"16.66,20.00",
		"15.66,20.00",
		"5.00,4.00",
		"3.00,3.00",
		"4.00,5.00"
	};

	string getTestCase(int index)
	{
		return testCases[index];
	}

	vector<string> cashBills
	{
		"HUNDRED",
		"FIFTY",
		"TWENTY",
		"TEN",
		"FIVE",
		"TOONIE",
		"LOONIE",
		"QUARTERS",
		"DIME",
		"NICKEL",
		"PENNY"
	};

	string getCashChange(double difference)
	{
		string change;
		vector<int> bills {10000,5000,2000,1000,500,200,100,25,10,5,1};

		int x = difference * 100;
		int reminder;
		int i = 0;
		while (x)
		{
			double quotient = x / bills[i];
			if (quotient > 0)
			{
				change.append(cashBills[i]);
				change.append(", ");
				if (x % bills[i] != 0)
				{
					x = x % bills[i];
					if (quotient > 1)
					{
						x = x + quotient * 100;
					}
				}
				else
				{
					if (x != bills[i])
						x--;
					else
						x = 0;
				}
			}
			else
			{
				i++;
			}
		}

		int length = change.length();
		change = change.substr(0, length - 2);
		return change;
	}

	string getChange(string input)
	{
		string result;
		int pos = input.find(',');
		int end = input.length() - 1;
		double price = stod(input.substr(0,pos-1));
		double cash = stod(input.substr(pos + 1, end));
		double difference = cash - price;

		if (difference < 0)
		{
			result = "ERROR";
		}

		else if (difference == 0)
		{
			result = "No Change";
		}

		else
		{
			result = getCashChange(difference);
		}

		return result;
	}

public:

	int execute()
	{
		FindChange data;
		int numberOfTestCases = data.testCases.size();
		
		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = data.getTestCase(i);
			cout << data.getChange(testCase) << endl;
		}
		return 0;
	}
};