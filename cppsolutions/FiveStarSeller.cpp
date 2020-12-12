#include<iostream>
#include<vector>
#include<algorithm>

using namespace std;

class DataType
{
public:
	vector<double> dataArray;
	double threshold;
};

class FiveStarSeller 
{

private:

	vector<DataType> testCases
	{
		{{4.0, 4.0, 1.0, 2.0, 3.0, 6.0}, 0.77},
	};

	DataType getInput(int index)
	{
		return testCases[index];
	}

	double getPercentageForGivenFractions(vector<double> fractionArray)
	{
		double sum = 0;
		int loopSize = fractionArray.size();
		for (int i = 0; i < loopSize; i = i + 2)
		{
			sum = sum + fractionArray[i] / fractionArray[i + 1];
		}
		return sum/(loopSize/2);
	}

	vector<double> getFractionArray(vector<double> dataArray)
	{
		vector<double> resultArray;
		for (int i = 0; i < dataArray.size(); i = i + 2)
		{
			resultArray.push_back(dataArray[i] / dataArray[i + 1]);
		}
		return resultArray;
	}

	vector<double> getDifferenceArray(vector<double> v1, vector<double> v2)
	{
		vector<double> diffArray;
		for (int i = 0; i < v1.size(); i++)
		{
			diffArray.push_back(abs(v1[i] - v2[i]));
		}
		return diffArray;
	}

	vector<double> updateFractionArray(vector<double> dataArray)
	{
		vector<double> originalDataArray = dataArray;
		vector<double> originalFractionArray = getFractionArray(dataArray);
		
		int length = dataArray.size();

		for (int i = 0; i < length; i++)
		{
			dataArray[i] = dataArray[i] + 1;
		}

		vector<double> currentFractionArray = getFractionArray(dataArray);
		vector<double> differenceArray = getDifferenceArray(originalFractionArray, currentFractionArray);

		vector<double>::iterator result = max_element(differenceArray.begin(), differenceArray.end());
		int positionToUpdate = distance(differenceArray.begin(), result);

		int index = (positionToUpdate + 1) * 2 - 2;
		originalDataArray[index] = originalDataArray[index] + 1;
		originalDataArray[index + 1] = originalDataArray[index + 1] + 1;

		return originalDataArray;
	}

	int getMinimumNumberOfReview(DataType data)
	{
		int count = 0;

		while (getPercentageForGivenFractions(data.dataArray) < data.threshold)
		{
			data.dataArray = updateFractionArray(data.dataArray);
			count++;
		}
		return count;
	}

public:

	int execute()
	{
		FiveStarSeller data;
		int numberOfCases = data.testCases.size();

		for (int i = 0; i < numberOfCases; i++)
		{
			DataType testCase = data.getInput(i);
			cout << data.getMinimumNumberOfReview(testCase) << endl;
		}

		return 0;
	}
};