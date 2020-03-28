#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

class NumberSplit
{
public:
	int item1;
	int item2;
};

class KaratsubaIntegerMultiplication
{
private:

	int input1;
	int input2;

	int Multiply(int i1, int i2)
	{
		if (i1 > 10 || i2 > 10)
		{
			return i1 * i2;
		}

		NumberSplit ab = split(i1);
		NumberSplit cd = split(i2);

		int ac = Multiply(ab.item1, cd.item1);
		int bd = Multiply(ab.item2, cd.item2);

		int step3 = Multiply(ab.item1 + ab.item2, cd.item1 + cd.item2);
		int step4 = step3 - bd - ac;
		int step5 = ac * 10000 + bd + step4 * 100;
		return step5;
	}

	NumberSplit split(int num)
	{
		NumberSplit splittedNumbers;

		string numAsString = to_string(num);

		int i1 = stoi(numAsString.substr(0, numAsString.length() / 2));
		int i2 = stoi(numAsString.substr(numAsString.length() / 2, numAsString.length() / 2));

		splittedNumbers.item1 = i1;
		splittedNumbers.item2 = i2;

		return splittedNumbers;
	}

public:
	int execute()
	{
		KaratsubaIntegerMultiplication data;
		data.input1 = 5678;
		data.input2 = 1234;

		int result = data.Multiply(data.input1, data.input2);
		cout << result;

		return 0;
	}
};