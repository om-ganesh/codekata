#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class SlidingWindowMaximum
{
private:

	vector<vector<int>> testCases{
		{1 , 2 , 3 , 1 , 4 , 5, 2, 3, 6}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	vector<int> getSlidingWindowMaxArray(vector<int> array, int k)
	{
		int n = array.size();
		vector<int> result;

		if (k <= 1)
		{
			return array;
		}

		else if (k == n)
		{
			vector<int>::iterator it = max_element(array.begin(), array.end());
			result.push_back(*it);
			return result;
		}

		else
		{
			for (int i = 0; i <= n - k; i++)
			{
				int max = array[i];
				for (int j = i; j < i + k; j++)
				{
					if (array[j] > max)
					{
						max = array[j];
					}
				}
				result.push_back(max);
			}
			return result;
		}
	}

public:

	int execute()
	{
		SlidingWindowMaximum data;
		int numberOfTestCases = data.testCases.size();
		vector<int> result;
		int k = 3;

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getInput(i);
			result = data.getSlidingWindowMaxArray(testCase, k);
		}
		return 0;
	}
};