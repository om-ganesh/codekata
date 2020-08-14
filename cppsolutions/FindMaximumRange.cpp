#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

class FindMaximumRange 
{

private:

	vector<vector<int>> testCases {
		{1, 2, 3, 4, 6, 7, 8, 9},
		{0, 2, 3, 5, 7, 9, -1}, 
	};

	vector<int> getInputArray(int index)
	{
		return testCases[index];
	}

	int findMaximumRange(vector<int> array)
	{
		int result = 0;
		int length = array.size();
		int counter = 1;
		for (int i = 0; i < length - 1; i++)
		{
			if (array[i] + 1 != array[i + 1])
			{
				if (counter > result)
				{
					result = counter;
				}

				counter = 1;
			}
			else
			{
				counter++;
			}
		}

		return counter > result ? counter : result;
	}

public:

	int execute()
	{
		FindMaximumRange data;
		int numberOfTestCases = data.testCases.size();
		vector<int> input;
		int output;

		for (int i = 0; i < numberOfTestCases; i++)
		{
			input = data.getInputArray(i);
			sort(input.begin(), input.end());
			output = data.findMaximumRange(input);
			cout << "Test Case: " << i << ", maximum range: " << output << endl;
		}

		return 0;
	}
};