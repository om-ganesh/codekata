#include <iostream>
#include <vector>

using namespace std;

class FindMaxTwoItems
{
private:
	vector<vector<int>> testCases
	{
		{10, 7, 5, 8, 11, 9},
		{10, 7, 5, 8, 1, 9},
		{1, 1, 2, 3, 6, 7, 7, 4, 6}
	};

	vector<int> getTestCases(int index)
	{
		return testCases[index];
	}

	vector<int> getMaxTwoElements(vector<int> input)
	{
		vector<int> result;
		if (input.size() < 2)
			result.push_back(0);
		else
		{
			int max2 = input[1];
			int max = input[0];
			for (int i = 2; i < input.size(); i++)
			{
				if (input[i] > max)
				{
					max2 = max;
					max = input[i];
				}
				else if (input[i] > max2)
				{
					max2 = input[i];
				}
			}
			result.push_back(max);
			result.push_back(max2);
		}
		return result;
	}
public:
	int execute()
	{
		FindMaxTwoItems data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getTestCases(i);
			vector<int> result = data.getMaxTwoElements(testCase);
		}
		return 0;
	}
};