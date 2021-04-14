#include <vector>
#include <string>
#include <iostream>
#include <algorithm>

using namespace std;

class Sudoko
{
private:
	vector<vector<vector<int>>> testCases
	{
		{{1,3,2,5,4,6,9,8,7},
		{4,6,5,8,7,9,3,2,1},
		{7,9,8,2,1,3,6,5,4},
		{9,2,1,4,3,5,8,7,6},
		{3,5,4,7,6,8,2,1,9},
		{6,8,7,1,9,2,5,4,3},
		{5,7,6,9,8,1,4,3,2},
		{2,4,3,6,5,7,1,9,8},
		{8,1,9,3,2,4,7,6,5}},

		{{1,3,2,5,4,6,9,2,7},
		{4,6,5,8,7,9,3,8,1},
		{7,9,8,2,1,3,6,5,4},
		{9,2,1,4,3,5,8,7,6},
		{3,5,4,7,6,8,2,1,9},
		{6,8,7,1,9,2,5,4,3},
		{5,7,6,9,8,1,4,3,2},
		{2,4,3,6,5,7,1,9,8},
		{8,1,9,3,2,4,7,6,5}}
	};

	vector<vector<int>> getTestCase(int index)
	{
		return testCases[index];
	}

	bool doesMatchWithIdeal(vector<int> ideal, vector<int> testCase)
	{
		if (ideal == testCase)
		{
			return true;
		}
		else {
			return false;
		}
	}

	vector<int> getGridByLocation(vector<vector<int>> matrix, int x, int y)
	{
		vector<int> out;
		for (int i = x; i < x+3; i++)
		{
			for (int j = y; j < y+3; j++)
			{
				out.push_back(matrix[i][j]);
			}
		}
		return out;
	}

	bool sudoku(vector<vector<int>> grid) {

		vector<int> ideal = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		bool allValid = true;
		// Check all the rows

		for (int i = 0; i < 9; i++)
		{
			vector<int> testCase = grid[i];
			sort(testCase.begin(), testCase.end());
			if (!doesMatchWithIdeal(ideal, testCase))
			{
				return false;
			}
		}

		// Check all the cols

		for (int i = 0; i < 9; i++)
		{
			vector<int> testCase;
			for (int j = 0; j < 9; j++)
			{
				testCase.push_back(grid[j][i]);
			}
			sort(testCase.begin(), testCase.end());
			if (!doesMatchWithIdeal(ideal, testCase))
			{
				return false;
			}
		}

		// Check all the grids

		vector<int> gridLocations{ 0, 3, 6 };

		for (int i = 0; i <= 6; i = i + 3)
		{
			for (int j = 0; j <= 6; j = j + 3)
			{
				vector<int> testCase = getGridByLocation(grid, i, j);
				sort(testCase.begin(), testCase.end());
				if (!doesMatchWithIdeal(ideal, testCase))
				{
					return false;
				}
			}
		}

		return true;
		
	}

public:
	int execute()
	{
		Sudoko data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<vector<int>> testCase = data.getTestCase(i);
			cout << data.sudoku(testCase) << endl;
		}
		return 0;
	}
};