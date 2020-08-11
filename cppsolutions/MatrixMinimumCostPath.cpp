#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

class MatrixMinimumCostPath {
private:

	vector<vector<int>> Matrix;
	vector<vector<int>> tempCostMatrix;
	vector<int> minimumCostPath;

	void generateData()
	{
		int row = 4;
		int col = 4;

		for (int i = 0; i < row; i++)
		{
			vector<int> tempRow;
			for (int j = 0; j < col; j++)
			{
				int randomInteger = rand() % 10;
				tempRow.push_back(randomInteger);
			}
			Matrix.push_back(tempRow);
		}
	}

	void calculateMinimumCostPath()
	{
		int numOfRows = Matrix.size();
		int numofCols = Matrix[0].size();

		minimumCostPath.push_back(0);
		minimumCostPath.push_back(0);

		for (int i = 0; i < numOfRows; i++)
		{
			vector<int> temp;
			for (int j = 0; j < numofCols; j++)
			{
				temp.push_back(0);
			}
			tempCostMatrix.push_back(temp);
		}

		for (int i = 0; i < numOfRows; i++)
		{
			for (int j = 0; j < numofCols; j++)
			{
				if (i == 0 && j == 0)
				{
					tempCostMatrix[i][j] = Matrix[i][j];
				}
				else if (i == 0 && j > 0)
				{
					tempCostMatrix[i][j] = Matrix[i][j] + tempCostMatrix[i][j - 1];
				}
				else if (j == 0 && i > 0)
				{
					tempCostMatrix[i][j] = Matrix[i][j] + tempCostMatrix[i-1][j];
				}
				else
				{
					tempCostMatrix[i][j] = Matrix[i][j] + min(tempCostMatrix[i][j-1], tempCostMatrix[i-1][j]);

					if (min(tempCostMatrix[i][j - 1], tempCostMatrix[i - 1][j]) == tempCostMatrix[i][j - 1])
					{
						minimumCostPath.push_back(i);
						minimumCostPath.push_back(j - 1);
					}

					if (min(tempCostMatrix[i][j - 1], tempCostMatrix[i - 1][j]) == tempCostMatrix[i - 1][j])
					{
						minimumCostPath.push_back(i-1);
						minimumCostPath.push_back(j);
					}
				}
			}	
		}

		minimumCostPath.push_back(numOfRows-1);
		minimumCostPath.push_back(numofCols-1);
	}

	void printMatrix(vector<vector<int>> printThisMatrix)
	{
		int numOfRows = printThisMatrix.size();
		int numofCols = printThisMatrix[0].size();

		for (int i = 0; i < numOfRows; i++)
		{
			for (int j = 0; j < numofCols; j++)
			{
				cout << printThisMatrix[i][j] << " ";
			}
			cout << endl;
		}
	}

	void printMinimumCostPath()
	{
		int length = minimumCostPath.size();
		int prevX, prevY;

		prevX = minimumCostPath[0];
		prevY = minimumCostPath[1];

		cout << "(" << minimumCostPath[0] << "," << minimumCostPath[1] << ")-->";
		for (int i = 2; i < length; i = i+2)
		{
			if ((minimumCostPath[i] == prevX) ^ (minimumCostPath[i+1] == prevY))
			{
				cout << "(" << minimumCostPath[i] << "," << minimumCostPath[i + 1] << ")";
				
				if (i < length - 2)
					cout << "-->";

				prevX = minimumCostPath[i];
				prevY = minimumCostPath[i + 1];
			}
		}
		// cout << "-->(" << minimumCostPath[length - 2] << "," << minimumCostPath[length - 1] << ").";
	}

public:
	int execute()
	{
		MatrixMinimumCostPath mat;
		mat.generateData();
		mat.printMatrix(mat.Matrix);
		mat.calculateMinimumCostPath();
		mat.printMatrix(mat.tempCostMatrix);
		mat.printMinimumCostPath();
		return 0;
	}
};