#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class MaxDifferenceInArray
{
private:
	// vector<int> array{ 2, 5, 1, 7, 3, 9, 5 };
	// vector<int> array{ 22,2, 12, 5, 4, 7, 3, 19, 5 };
	vector<int> array;
	int length = 15;
	
	void getData()
	{
		for (int i = 0; i < length; i++)
		{
			array.push_back(rand() % 100);
		}
	}

	void printData()
	{
		for (int i = 0; i < length; i++)
		{
			cout << array[i] << " ";
		}
	}

	void findMaxDiff()
	{
		int maxElement = array[length-1];
		int maxDifference = -1;

		for (int i = length - 2; i > 0; i--)
		{
			if (array[i] > maxElement)
			{
				maxElement = array[i];
			}
			else if (maxElement > array[i])
			{
				maxDifference = max(maxDifference, maxElement - array[i]);
			}
		}
		cout << endl << maxDifference;
	}

public:
	int execute()
	{
		MaxDifferenceInArray data;
		data.getData();
		data.printData();
		data.findMaxDiff();
		return 0;
	}
};