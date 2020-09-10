#include <iostream>
#include <vector>
#include <string>
#include <numeric>

using namespace std;

class EqualSumSubArray
{

private:

	vector<vector<int>> testCases{
		{1 , 2 , 3 , 4 , 5 , 5},
		{4, 1, 2, 3},
		{5, 2, 3, 1},
		{4, 3, 2, 1}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	int getEqualSumSubArray(vector<int> input)
	{
		int index = -1;
		int sumOfAllElements = accumulate(input.begin(), input.end(), 0);
		int sumToBeFoundForEachSubArray = sumOfAllElements / 2;
		int lengthOfArray = input.size();

		if (sumOfAllElements % 2 != 0)
		{
			return index;
		}

		int sum = 0;
		int count = 0;
		
		for (int i = 0; i < lengthOfArray; i++)
		{
			if (sum == sumToBeFoundForEachSubArray)
			{
				count++;
				if (count < 2)
					index = i - 1;

				i--;
				sum = 0;
			}
			else
			{
				sum = sum + input[i];
			}
		}

		return index;
	}

public:
	int execute()
	{
		EqualSumSubArray es;
		int numberOfCases = es.testCases.size();

		for (int i = 0; i < numberOfCases; i++)
		{
			vector<int> testCase = es.getInput(i);
			cout << "SubArray to be splitted at index: " << es.getEqualSumSubArray(testCase) << endl;
		}
		return 0;
	}
};