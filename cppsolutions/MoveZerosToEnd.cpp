#include <iostream>
#include <vector>

using namespace std;

class MoveZerosToEnd
{
private:
	vector<vector<int>> testCases{
		{2 , -1 , 5 , 0 , 2 , -7, 0, 0, 3, 0}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	vector<int> moveZerosToEnd(vector<int> array)
	{
		int count = 0;
		for (int i = 0; i < array.size(); i++)
		{
			if (array[i] != 0)
			{
				array[count] = array[i];
				count++;
			}
		}

		int numberOfZeros = array.size() - count;
		for (int i = count; i < array.size(); i++)
		{
			array[i] = 0;
		}

		return array;
	}

public:
	int execute()
	{
		MoveZerosToEnd data;
		int numberOfTestCases = data.testCases.size();
		
		int k = 3;

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getInput(i);
			testCase = moveZerosToEnd(testCase);
		}
		return 0;
	}
};