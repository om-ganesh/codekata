#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class ShuffleNumbers
{
private:
	vector<int> testCases
	{
		0,
		1,
		2,
		3,
		10,
		100,
		250,
		-10,
		-500
	};

	int getTestCase(int index)
	{
		return testCases[index];
	}

	void randomShuffle(vector<int>& data)
	{
		int n = data.size();
		for (int i = n - 1; i > 0; --i)
		{
			int randomNumber = rand() % (i + 1);
			int temp = data[i];
			data[i] = data[randomNumber];
			data[randomNumber] = temp;
		}
	}

	vector<int> generateDataArray(int n)
	{
		vector<int> dataArray;
		if (n == 0)
		{
			cout << "Input must be greater or equal 1." << endl;
			return dataArray;
		}

		if (n < 0)
		{
			n = n * -1;
		}

		if (n == 1)
		{
			dataArray.push_back(1);
		}

		if (n > 1)
		{
			for (int i = 1; i <= n; i++)
			{
				dataArray.push_back(i);
			}
		}
		return dataArray;
	}

	vector<int> getRandomOrderingOf1ToN(int n)
	{
		vector<int> data = generateDataArray(n);
		// Using STL:
		// random_shuffle(data.begin(), data.end());
		// Using My Implementation:
		randomShuffle(data);
		return data;
	}

	void displayVector(vector<int> vectorToDisplay)
	{
		for (int i = 0; i < vectorToDisplay.size(); i++)
		{
			cout << vectorToDisplay[i] << " ";
		}
		cout << endl;
	}

public:

	int execute()
	{
		ShuffleNumbers data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			int testCase = data.getTestCase(i);
			vector<int> result = data.getRandomOrderingOf1ToN(testCase);
			data.displayVector(result);
		}

		return 0;
	}
};