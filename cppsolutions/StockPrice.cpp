#include <vector>
#include <iostream>

using namespace std;

class StockPrice
{
private:

	vector<vector<int>> testCases{
		{10, 7, 5, 8, 11, 9},
		{10, 7, 11, 5, 8, 9},
		{10, 7, 7},
		{10, 7, 4, 3}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	int getMaxProfit(vector<int> inputArray)
	{
		int maxDifference = inputArray[1] - inputArray[0];
		int minNumber = inputArray[0];

		for (int i = 0; i < inputArray.size(); i++)
		{
			if ((inputArray[i] - minNumber) > maxDifference)
				maxDifference = inputArray[i] - minNumber;
			if (inputArray[i] < minNumber)
				minNumber = inputArray[i];
		}
		return maxDifference;
	}

public:

	int execute()
	{
		StockPrice sp;
		int numberOfCases = sp.testCases.size();

		for (int i = 0; i < numberOfCases; i++)
		{
			vector<int> testCase = sp.getInput(i);
			cout << sp.getMaxProfit(testCase) << endl;
		}

		return 0;
	}
};