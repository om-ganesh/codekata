#include <iostream>
#include <vector>
#include <stack>

using namespace std;

struct coordinate
{
	int x;
	int y;
};

class NumberOfIslands
{
private:
	vector<vector<vector<int>>> testCases{
		{
			{1,1,1,1,0},
			{1,1,0,1,0},
			{1,1,0,0,0},
			{0,0,0,0,0}
		},
		{
			{1,1,0,0,0},
			{1,1,0,0,0},
			{0,0,1,0,0},
			{0,0,0,1,1}
		}

	};

	vector<vector<int>> getInput(int index)
	{
		return testCases[index];
	}

	vector<vector<int>> negateMatrix(vector<vector<int>> matrix)
	{
		vector<vector<int>> negatedMatrix;
		int row = matrix.size();
		int col = matrix[0].size();

		for (int i = 0; i < row; i++)
		{
			vector<int> rowVector;
			for (int j = 0; j < col; j++)
			{
				if (matrix[i][j] == 1)
					rowVector.push_back(-1);
				else
					rowVector.push_back(0);
			}
			negatedMatrix.push_back(rowVector);
		}
		return negatedMatrix;
	}

	void connectedComponents(stack<coordinate> &neighboringCoordinate, vector<vector<int>> &negatedMatrix, int label, int x, int y, int row, int col)
	{
		coordinate up, down, left, right;
		negatedMatrix[x][y] = label;

		if (x > 0)
		{
			up.x = x - 1;
			up.y = y;
			if (negatedMatrix[up.x][up.y] == -1)
			{
				neighboringCoordinate.push(up);
			}
		}

		if (y > 0)
		{
			left.x = x;
			left.y = y - 1;
			if (negatedMatrix[left.x][left.y] == -1)
			{
				neighboringCoordinate.push(left);
			}
		}

		if (x < row - 1)
		{
			down.x = x + 1;
			down.y = y;
			if (negatedMatrix[down.x][down.y] == -1)
			{
				neighboringCoordinate.push(down);
			}
		}

		if (y < col - 1)
		{
			right.x = x;
			right.y = y + 1;
			if (negatedMatrix[right.x][right.y] == -1)
			{
				neighboringCoordinate.push(right);
			}
		}

		while (!neighboringCoordinate.empty())
		{
			coordinate cd = neighboringCoordinate.top();
			neighboringCoordinate.pop();
			connectedComponents(neighboringCoordinate, negatedMatrix, label, cd.x, cd.y, row, col);
		}
	}

	int findComponents(vector<vector<int>> negatedMatrix, int label)
	{
		int numberOfConnectedComponents = 0;
		int row = negatedMatrix.size();
		int col = negatedMatrix[0].size();

		stack<coordinate> neighboringCoordinate;

		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < col; j++)
			{
				if (negatedMatrix[i][j] == -1)
				{
					label = label + 1;
					connectedComponents(neighboringCoordinate, negatedMatrix, label, i, j, row, col);
				}
			}
		}

		numberOfConnectedComponents = label;
		return numberOfConnectedComponents;
	}

	int getNumberOfIslands(vector<vector<int>> matrix)
	{
		vector<vector<int>> negatedMatrix = negateMatrix(matrix);
		int label = 0;
		int numberOfIslands = findComponents(negatedMatrix, label);
		return numberOfIslands;
	}

public:
	int execute()
	{
		NumberOfIslands data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<vector<int>> testCase = data.getInput(i);
			cout << "Number of Islands: " << data.getNumberOfIslands(testCase) << endl;
		}
		return 0;
	}
};