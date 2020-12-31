#include <iostream>
#include <vector>
#include <algorithm>
#include <tuple>
#include <string>

using namespace std;

class CriticalAndPseudocriticalEdges
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
		int x1 = points[x * 2];
		int y1 = points[x * 2 + 1];
		int x2 = points[y * 2];
		int y2 = points[y * 2 + 1];

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
		// return min;
	}

	bool isUnique(int item, vector<int> vect)
	{
		int count = 0;
		bool unique = false;
		for (int i = 0; i < vect.size(); i++)
		{
			if (vect[i] == item)
				count++;
		}

		if (count == 1)
			unique = true;

		return unique;
	}

	string findCriticalEdges(vector<vector<int>> costMatrix)
	{
		string criticalEdges = "[";
		string PseudoCriticalEdges = "[";

		int item;
		int length = costMatrix.size();
		bool unique = false;

		// take the first row, find min, put -1 in min position:
		vector<int> oneRow = costMatrix[0];
		item = get<0>(findMinimumGreaterThanZero(oneRow));
		unique = isUnique(item, oneRow) ? true : false;
		int indexOfMinElement = get<1>(findMinimumGreaterThanZero(oneRow));
		oneRow[indexOfMinElement] = -1;
		costMatrix[0] = oneRow;

		if (unique)
		{
			criticalEdges.append("0,");
			criticalEdges.append(to_string(indexOfMinElement));
			criticalEdges.append(",");
		}

		int row = 1;
		for (int col = 0; col < length; col++)
		{
			// upper triangular matrix means where col > row
			if (col > row)
			{
				vector<int> thisColumn = getColumn(col, row, costMatrix);
				row = col;
				item = get<0>(findMinimumGreaterThanZero(thisColumn));
				unique = isUnique(item, oneRow) ? true : false;
				indexOfMinElement = get<1>(findMinimumGreaterThanZero(thisColumn));
				costMatrix[indexOfMinElement][col] = -1;

				if (unique)
				{
					criticalEdges.append(to_string(indexOfMinElement));
					criticalEdges.append(",");
				}
			}
		}

		criticalEdges.pop_back();
		criticalEdges.append("]");
		return criticalEdges;
	}

public:
	int execute()
	{
		CriticalAndPseudocriticalEdges data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getInput(i);
			vector<vector<int>> testCaseAsMatrix = data.representGraphAsMatrix(testCase);
			string result = data.findCriticalEdges(testCaseAsMatrix);
			cout << "Test Case # " << i << " and Result = " << result << endl;
		}

		return 0;
	}
};