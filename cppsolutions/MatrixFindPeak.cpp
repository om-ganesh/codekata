#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class MatrixFindPeak
{
private:
	vector<vector<int>> Matrix;
	int row = 4;
	int col = 4;
	int peak;

	void getMatrix()
	{
		for (int i = 0; i < row; i++)
		{
			vector<int> tempRow;
			for (int j = 0; j < col; j++)
			{
				tempRow.push_back(rand() % 10);
			}
			Matrix.push_back(tempRow);
		}
	}

	void getPeak()
	{
		int max;
		for (int i = 0; i < row; i++)
		{
			max = *max_element(Matrix[i].begin(), Matrix[i].end());
			if (max > peak)
				peak = max;
		}
		
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

public:
	int execute()
	{
		MatrixFindPeak data;
		data.getMatrix();
		data.getPeak();
		data.printMatrix(data.Matrix);
		cout << data.peak;
		return 0;
	}
};