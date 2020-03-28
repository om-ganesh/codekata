#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class KLargestInArray
{
private:
	vector<int> array;
	
	void getData(int numOfElement)
	{
		for (int i = 0; i < numOfElement; i++)
		{
			array.push_back(rand() % 100);
		}
	}

	void printData()
	{
		for (int i = 0; i < array.size(); i++)
		{
			cout << array[i] << " ";
		}
		cout << endl;
	}

	void findKLargestElemets(int k)
	{
		int length = array.size() - 1;
		sort(array.begin(), array.end());
		for (int i = length; i > (length-k); i--)
		{
			cout << array[i] << " ";
		}
		cout << endl;
	}

public:
	int execute()
	{
		KLargestInArray data;
		int numOfElement = 15;
		int k = 4;

		data.getData(numOfElement);
		data.printData();
		data.findKLargestElemets(k);

		return 0;
	}
};