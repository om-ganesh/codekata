#include <iostream>
#include <vector>

using namespace std;

class MergeSort
{
private:

	vector<int> arrayToSort;

	int length = 15;

	void getData()
	{
		for (int i = 0; i < length; i++)
		{
			// rand() % 10 means 1 digit number
			// rand() % 100 means 2 digit number

			arrayToSort.push_back(rand() % 10);
		}
	}

	void printArray(vector<int> arrayToPrint)
	{
		for (int i = 0; i < length; i++)
		{
			cout << arrayToPrint[i] << " ";
		}
		cout << endl;
	}

	void merge(int left, int middle, int right)
	{
		vector<int> leftSubArray;
		vector<int> rightSubArray;

		int lengthOfLeftSubArray = middle - left + 1;
		int lengthOfRightSubArray = right - middle;

		for (int i = 0; i < lengthOfLeftSubArray; i++)
		{
			leftSubArray.push_back(arrayToSort[left + i]);
		}
		for (int j = 0; j < lengthOfRightSubArray; j++)
		{
			rightSubArray.push_back(arrayToSort[middle + 1 + j]);
		}

		int k = left;
		int i = 0;
		int j = 0;

		while (i < lengthOfLeftSubArray && j < lengthOfRightSubArray)
		{
			if (leftSubArray[i] <= rightSubArray[j])
			{
				arrayToSort[k] = leftSubArray[i];
				i++;
			}
			else
			{
				arrayToSort[k] = rightSubArray[j];
				j++;
			}
			k++;
		}

		while (i < lengthOfLeftSubArray)
		{
			arrayToSort[k] = leftSubArray[i];
			i++;
			k++;
		}

		while (j < lengthOfRightSubArray)
		{
			arrayToSort[k] = rightSubArray[j];
			j++;
			k++;
		}

	}

	void mergeSort(int left, int right)
	{
		if (left < right)
		{
			int middle = left + (right - left) / 2;

			mergeSort(left, middle);
			mergeSort(middle + 1, right);

			merge(left, middle, right);
		}
	}

public:

	int execute()
	{
		MergeSort data;
		data.getData();
		data.printArray(data.arrayToSort);

		int left, right;
		left = 0;
		right = data.arrayToSort.size() - 1;

		data.mergeSort(left, right);
		data.printArray(data.arrayToSort);
		return 0;
	}
};