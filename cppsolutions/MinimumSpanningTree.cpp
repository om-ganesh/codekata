#include <iostream>
#include <vector>
#include <algorithm>
#include <tuple>

using namespace std;

class MinimumSpanningTree
{
private:

	vector<vector<int>> testCases{
		{0,0,2,2,3,10,5,2,7,0},
		{3,12,-2,5,-4,1},
		{0,0,1,1,1,0,-1,1}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	int getDifferenceBetweenPoints(int x, int y, vector<int> points)
	{
		int x1 = points[x*2];
		int y1 = points[x*2+1];
		int x2 = points[y*2];
		int y2 = points[y*2+1];

		int difference = abs(x1 - x2) + abs(y1 - y2);
		return difference;
	}

	vector<vector<int>> representGraphAsMatrix(vector<int> pointVector)
	{
		int numberOfPoints = pointVector.size() / 2;
		vector<vector<int>> matrix;
		for (int row = 0; row < numberOfPoints; row++)
		{
			vector<int> oneRow;
			for (int col = 0; col < numberOfPoints; col++)
			{
				if (row == col)
				{
					oneRow.push_back(0);
				}
				else
				{
					oneRow.push_back(getDifferenceBetweenPoints(row, col, pointVector));
				}
			}
			matrix.push_back(oneRow);
		}
		return matrix;
	}

	vector<int> getColumn(int columnNumber, int until, vector<vector<int>> costMatrix)
	{
		vector<int> outputVector;
		for (int i = 0; i <= until; i++)
		{
			outputVector.push_back(costMatrix[i][columnNumber]);
		}
		return outputVector;
	}
	
	tuple<int, int> findMinimumGreaterThanZero(vector<int> vect)
	{
		int min = *max_element(vect.begin(), vect.end());
		int pos = 0;
		for (int i = 0; i < vect.size(); i++)
		{
			if (vect[i] > 0 && vect[i] < min)
			{
				min = vect[i];
				pos = i;
			}
		}
		return make_tuple(min, pos);
	}

	int findMinimumCost(vector<vector<int>> costMatrix)
	{
		int sum = 0;
		int length = costMatrix.size();

		// take the first row, find min, put -1 in min position:
		vector<int> oneRow = costMatrix[0];
		sum = sum + get<0>(findMinimumGreaterThanZero(oneRow));
		int indexOfMinElement = get<1>(findMinimumGreaterThanZero(oneRow));
		oneRow[indexOfMinElement] = -1;
		costMatrix[0] = oneRow;

		int row = 1;
		for (int col = 0; col < length; col++)
		{
			// upper triangular matrix means where col > row
			if (col > row)
			{
				vector<int> thisColumn = getColumn(col, row, costMatrix);
				row = col;
				sum = sum + get<0>(findMinimumGreaterThanZero(thisColumn));
				indexOfMinElement = get<1>(findMinimumGreaterThanZero(thisColumn));
				costMatrix[indexOfMinElement][col] = -1;
			}
		}

		return sum;
	}

public:
	int execute()
	{
		MinimumSpanningTree data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getInput(i);
			vector<vector<int>> testCaseAsMatrix = data.representGraphAsMatrix(testCase);
			int cost = data.findMinimumCost(testCaseAsMatrix);
			cout << "Test Case # " << i << " and Cost = " << cost << endl;
		}

		return 0;
	}
};