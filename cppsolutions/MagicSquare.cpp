// Magic Square :
//
// The sum in each row / col / diag for a matrix of size n is M, where M = n(n ^ 2 + 1) / 2
// The first number(1) to be placed at position(n / 2, n - 1).Let this position be(i, j).
// The next number(2) is placed at(i - 1, j + 1).If this position already has a number then place next number at(i + 1, j - 2).That is(i - 1 + 1, j + 1 - 2) = > (i, j - 1)

#include <iostream>
#include <vector>

using namespace std;

class MagicSquare
{
private:

	vector<vector<int>> magicSquare;
	int dimension;

	void initializeTheMatrixWithZero(int n)
	{
		for (int i = 0; i < n; i++)
		{
			vector<int> temp;
			for (int j = 0; j < n; j++)
			{
				// magicSquare[i][j] = 0;
				temp.push_back(0);
			}
			magicSquare.push_back(temp);
		}
	}

	int manageOverflow(int num)
	{
		if (num < 0)
		{
			num = dimension + num;
		}

		if (num >= dimension)
		{
			num = num - dimension;
		}

		return num;
	}

	void getTheMatrix(int n)
	{
		int sum = n * (n * 2 + 1) / 2;
		int nextNumber = 1;
		int i = n / 2;
		int j = n - 1;

		for (int k = 0; k < n * n; k++)
		{
			if (magicSquare[i][j] == 0)
			{
				magicSquare[i][j] = nextNumber;
			}
			else
			{
				i = i + 1;
				j = j - 2;

				i = manageOverflow(i);
				j = manageOverflow(j);

				magicSquare[i][j] = nextNumber;
			}

			i = i - 1;
			j = j + 1;

			i = manageOverflow(i);
			j = manageOverflow(j);

			nextNumber++;
		}
	}

	void printMatrix()
	{
		int row = magicSquare.size();
		int col = magicSquare[0].size();

		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < col; j++)
			{
				cout << magicSquare[i][j] << " ";
			}
			cout << endl;
		}
	}

public:
	int execute()
	{
		MagicSquare data;
		data.dimension = 3;
		data.initializeTheMatrixWithZero(data.dimension);
		data.getTheMatrix(data.dimension);
		data.printMatrix();

		return 0;
	}
};