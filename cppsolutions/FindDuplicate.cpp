#include <iostream>
#include <string>
#include <vector>

using namespace std;

class FindDuplicate
{
private:
	vector<string> testCases
	{
		"5; 0, 1, 3, 2, 0",
		"20; 0, 1, 2, 4, 6, 7, 8, 9, 12, 11, 18, 4, 3, 5, 10, 13, 16, 14, 15, 17"
	};

	string getTestCase(int index)
	{
		return testCases[index];
	}

	vector<int> getIntArrayFromString(string data, int length)
	{
		vector<int> intArray;
		string number;
		int lastCommaPosition;

		for (int i = 0; i < length; i++)
		{
			if (data[i] != ',')
			{
				number.push_back(data[i]);
			}
			if (data[i] == ',')
			{
				intArray.push_back(stoi(number));
				number.clear();
				lastCommaPosition = i;
			}
		}

		string lastNumber = data.substr(lastCommaPosition + 1, length);
		intArray.push_back(stoi(lastNumber));

		return intArray;
	}

	vector<int> getHistogram(vector<int> array)
	{
		int size = array.size();
		vector<int> histogram(size);

		for (int i = 0; i < size; i++)
		{
			histogram[array[i]]++;
		}

		return histogram;
	}

	int getDuplicatePosition(vector<int> histogram)
	{
		int size = histogram.size();
		int i;

		for (i = 0; i < size; i++)
		{
			if (histogram[i] > 1)
				break;
		}
		return i;
	}

	int getDuplicateItem(string data)
	{
		int pos = data.find(';');
		int stringLength = data.length();

		int dataArrayLength = stoi(data.substr(0, pos));
		string dataArray = data.substr(pos + 1, stringLength);
		vector<int> intDataArray = getIntArrayFromString(dataArray, stringLength-pos);
		vector<int> histogram = getHistogram(intDataArray);
		
		return getDuplicatePosition(histogram);
	}

public:
	int execute()
	{
		FindDuplicate data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = data.getTestCase(i);
			cout << "Duplicate Value is: " << data.getDuplicateItem(testCase) << endl;;
		}
		return 0;
	}
};

