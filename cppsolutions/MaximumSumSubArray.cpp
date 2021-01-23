#include <iostream>
#include <vector>

using namespace std;

class MaximumSumSubArray
{
private:
	vector<vector<int>> testCases
	{
		{-2, 1, -3, 4, -1, 2, 1, -5, 4},
		{1},
		{0},
		{-1},
		{-1000}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	int getMax(int a, int b)
	{
		if (a > b)
			return a;
		if (b >= a)
			return b;
	}

	int getMaximumSumSubArray(vector<int> data)
	{
		int currentSum = data[0];
		int globalSum = data[0];

		for (int i = 1; i < data.size(); i++)
		{
			currentSum = getMax(data[i], currentSum + data[i]);
			if (currentSum > globalSum)
				globalSum = currentSum;
		}
		return globalSum;
	}
public:

	int execute()
	{
		MaximumSumSubArray data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getInput(i);
			cout << "Maximum Sum = " << data.getMaximumSumSubArray(testCase) << endl;
		}
		return 0;
	}
};