#include<iostream>
#include<vector>
#include<algorithm>
#include<array>

using namespace std;

class FindDistinctNumbers
{
private:
	vector<int> data;
	vector<int> histogram;
	array<int, 2> result;

	void getTestData(int idx)
	{
		vector<vector<int>> allTestCases{
			{1, 2, 3, 2, 1, 4},
			{2, 1, 3, 2}
		};

		data = allTestCases[idx];
	}

	void printArray(vector<int> a)
	{
		int length = a.size();
		for (int i = 0; i < length; i++)
		{
			cout << a[i] << " ";
		}
		cout << endl;
	}

	void generateHistogram()
	{
		int length = data.size();
		for (int i = 0; i < length; i++)
		{
			histogram.push_back(0);
		}

		for (int i = 0; i < length; i++)
		{
			histogram[data[i]]++;
		}
	}

	void findResult()
	{
		int length = histogram.size();
		int idx = 0;
		for (int i = 0; i < length; i++)
		{
			if (histogram[i] == 1)
				result[idx++] = i;
		}
	}

public:
	int execute()
	{
		FindDistinctNumbers object;
		object.getTestData(0);
		object.printArray(object.data);
		object.generateHistogram();
		object.printArray(object.histogram);
		object.findResult();
		cout << object.result[0] << " " << object.result[1] << endl;
		return 0;
	}
};