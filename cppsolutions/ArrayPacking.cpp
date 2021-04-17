#include <vector>
#include <string>
#include <iostream>
#include <bitset>

using namespace std;

class ArrayPacking
{
private:
	vector<vector<int>> testCases
	{
		{24, 85, 0}
	};

	vector<int> getTestCase(int index)
	{
		return testCases[index];
	}

	int arrayPacking(vector<int> a)
	{
		int numOfElements = a.size();
		int bitSize = numOfElements * 8;
		bitset<32> bits(0);
		string bitString = bits.to_string();

		for (int i = numOfElements, k = 0; i > 0; i--, k = k + 8)
		{
			bitset<8> num(a[i - 1]);
			string numString = num.to_string();
			bitString.replace(k, 8, numString);
		}
		
		bitset<32> res(bitString);

		for (int i = 0; i < 4 - numOfElements; i++)
		{
			res = res >> 8;
		}

		unsigned long result = res.to_ulong();
		return (int)result;
	}

public:
	int execute()
	{
		ArrayPacking data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getTestCase(i);
			cout << data.arrayPacking(testCase) << endl;
		}
		return 0;
	}
};