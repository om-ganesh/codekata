#include <vector>
#include <string>
#include <iostream>
#include <set>

using namespace std;

class DifferentSquares
{
private:
	vector<vector<vector<int>>> testCases
	{
        {{1,2,1},
         {2,2,2},
         {2,2,2},
         {1,2,3},
         {2,2,1}},

         {{9,9,9,9,9},
         {9,9,9,9,9},
         {9,9,9,9,9},
         {9,9,9,9,9},
         {9,9,9,9,9},
         {9,9,9,9,9}}
	};

    vector<vector<int>> getTestCase(int index)
	{
		return testCases[index];
	}

    string get2x2MatrixForPosition(int x, int y, vector<vector<int>> matrix)
    {
        int row = matrix.size();
        int col = matrix[0].size();

        string mat = to_string(matrix[x][y]) + ",";
        if (y + 1 < col)
        {
            mat = mat + to_string(matrix[x][y + 1]) + ",";
        }

        if (x + 1 < row)
        {
            mat = mat + to_string(matrix[x + 1][y]) + ",";
        }

        if (x + 1 < row && y + 1 < col)
        {
            mat = mat + to_string(matrix[x + 1][y + 1]);
        }

        if (y + 1 >= col || x + 1 >= row || x + 1 >= row || y + 1 >= col)
        {
            mat = "";
        }
        return mat;
    }

    int differentSquares(vector<vector<int>> matrix) {
        set<string> hashSet;

        int row = matrix.size();
        int col = matrix[0].size();
        int counter = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                string mat = get2x2MatrixForPosition(i, j, matrix);
                cout << mat << endl;
                if (!(hashSet.find(mat) != hashSet.end()))
                {
                    hashSet.insert(mat);
                    counter++;
                }
            }
        }
        return --counter;
    }
public:
	int execute()
	{
		DifferentSquares data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
            vector<vector<int>> testCase = data.getTestCase(i);
			cout << data.differentSquares(testCase) << endl;
		}
		return 0;
	}
};