#include <vector>
#include <iostream>

using namespace std;

class LongestOddEvenSequence
{
private:
	vector<vector<int>> testData{
		{1, 1, 2, 3, 6, 5, 5, 4, 6}
	};

	vector<int> getTestData(int index)
	{
		return testData[index];
	}

	int getLongestSequence(vector<int> testCase)
	{
		int length = testCase.size();
		int SUM = 0;
		
		// Declaring a vector of same length and initializes all with 1
		vector<int> types(length, 1);

		for (int i = 0; i < length; i++)
		{
			if (testCase[i] % 2 == 0)
				types[i] = 0;
		}

		int sum = 0;
		for (int i = 0; i < length - 1; i++)
		{
			if (types[i] == types[i + 1])
			{
				if (sum > SUM)
					SUM = sum;
				sum = 0;
			}
			else
			{
				sum++;
			}
		}

		return SUM+1;
	}

public:
	int execute()
	{
		LongestOddEvenSequence data;
		int numberOfTestCases = data.testData.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getTestData(i);
			int lengthOfLongestSequence = data.getLongestSequence(testCase);
			cout << lengthOfLongestSequence << endl;
		}
		return 0;
	}
};