#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class MaxSizeBlob
{
private:
	vector<vector<vector<int>>> testCases{
		{
			{1, 0, 0, 1, 1, 1},
			{1, 0, 1, 1, 0, 1},
			{0, 1, 1, 1, 1, 1},
			{0, 0, 1, 1, 1, 1}
		}
	};

	vector<vector<int>> getInput(int index)
	{
		return testCases[index];
	}

	int getMaximumSizeBlob(vector<vector<int>> inputMatrix)
	{
		int numOfColumn = inputMatrix[0].size();
		int numOfRow = inputMatrix.size();

		vector<int> rowVector(numOfColumn);
		fill(rowVector.begin(), rowVector.end(), 0);

		int maxArea = 0;

		for (int i = 0; i < numOfRow; i++)
		{
			int nonZeroCount = 0;
			int minHeight = numOfColumn * numOfRow;
			vector<int> countNonZero;
			vector<int> allMinHeights;

			for (int j = 0; j < numOfColumn; j++)
			{
				if (inputMatrix[i][j] == 0)
				{
					rowVector[j] = 0;
					countNonZero.push_back(nonZeroCount);
					nonZeroCount = 0;
					allMinHeights.push_back(minHeight);
					minHeight = numOfColumn * numOfRow;
				}
				else
				{
					rowVector[j] = rowVector[j] + inputMatrix[i][j];
					nonZeroCount++;
					if (rowVector[j] < minHeight)
					{
						minHeight = rowVector[j];
					}
				}
			}

			countNonZero.push_back(nonZeroCount);
			allMinHeights.push_back(minHeight);

			vector<int>::iterator  it = max_element(countNonZero.begin(), countNonZero.end());
			int maxCount = *it;
			int indexOfMaxCount = max_element(countNonZero.begin(), countNonZero.end()) - countNonZero.begin();
			int minimumLength = allMinHeights[indexOfMaxCount];
			int currentArea = maxCount * minimumLength;
			
			if (currentArea > maxArea)
			{
				maxArea = currentArea;
			}
		}
		return maxArea;
	}

public:
	int execute()
	{
		MaxSizeBlob data;
		int numOfTestData = data.testCases.size();
		
		for (int i = 0; i < numOfTestData; i++)
		{
			vector<vector<int>> inputMatrix = data.getInput(i);
			int maxArea = data.getMaximumSizeBlob(inputMatrix);
		}
		return 0;
	}
};