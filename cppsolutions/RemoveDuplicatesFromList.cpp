#include <list>
#include <vector>
#include <string>
#include <iostream>

using namespace std;

class RemoveDuplicatesFromList
{
private:
	vector<list<int>> testCases
	{
		{1, 2, 5, 3, 2, 1, 6, 9, 8, 7},
		{2, 3, 1, -2, -2, 4, 8, 5, 6}
	};

	list<int> getTestCase(int index)
	{
		return testCases[index];
	}

	list<int> removeDuplicates(list<int> input)
	{
		input.sort();
		// unique works only on sorted list
		input.unique();
		return input;
	}

	void printList(list<int> data)
	{
		list<int>::iterator it;
		for (it = data.begin(); it != data.end(); it++)
		{
			cout << *it << " ";
		}
		cout << endl;
	}
public:
	int execute()
	{
		RemoveDuplicatesFromList data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			list<int> testCase = data.getTestCase(i);
			//An alternate approach is you can convert the list to a vector:
			//vector<int> v(testCase.begin(), testCase.end());
			//list<int> l(v.begin(), v.end());
			printList(testCase);
			list<int> result = data.removeDuplicates(testCase);
			printList(result);
			cout << endl << endl;
		}
		return 0;
	}
};