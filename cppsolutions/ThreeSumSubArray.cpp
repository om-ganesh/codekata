#include <iostream>
#include <vector>

using namespace std;

class ThreeSumSubArray
{
private:

	vector<vector<int>> testCases{
		{-1 , 0 , 1 , 2 , -1 , -4}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	vector<vector<int>> getThreeSumSubArray(vector<int> array)
	{
		int length = array.size();
		vector<vector<int>> result;

		for (int i = 0; i < length - 2; i++)
		{
			for (int j = i + 1; j < length - 1; j++)
			{
				for (int k = j + 1; k < length; k++)
				{
					int a = array[i];
					int b = array[j];
					int c = array[k];
					if (a + b + c == 0)
					{
						vector<int> v;
						v.push_back(a);
						v.push_back(b);
						v.push_back(c);
						result.push_back(v);
					}
				}
			}
		}

		return result;
	}

public:
	int execute()
	{
		ThreeSumSubArray data;

		int numberOfTestCases = data.testCases.size();
		vector<vector<int>> result;

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getInput(i);
			result = data.getThreeSumSubArray(testCase);
		}

		return 0;
	}
};