#include <iostream>
#include <tuple>
#include <vector>

using namespace std;

class BresenhamCircle
{

private:

	int radius;
	int xc;
	int yc;

	void printPixel()
	{

	}

	void setRadius(int r)
	{
		radius = r;
	}

	void setCenter(int x, int y)
	{
		xc = x;
		yc = y;
	}

	vector<vector<int>> testCases
	{
		{0, 0, 0},
		{3, 0, 0},
		{5, 0, 0}
	};

	vector<int> getTestCase(int index)
	{
		return testCases[index];
	}

	void printPixel(int x, int y)
	{
		// cout << "(" << ", " << ")" << endl;

		cout << "(" << xc + x << ", " << yc + y << ")" << endl;
		cout << "(" << xc - x << ", " << yc + y << ")" << endl;
		cout << "(" << xc + x << ", " << yc - y << ")" << endl;
		cout << "(" << xc - x << ", " << yc - y << ")" << endl;
		cout << "(" << xc + y << ", " << yc + x << ")" << endl;
		cout << "(" << xc - y << ", " << yc + x << ")" << endl;
		cout << "(" << xc + y << ", " << yc - x << ")" << endl;
		cout << "(" << xc - y << ", " << yc - x << ")" << endl;
	}

	void getCircle()
	{
		int x = 0;
		int y = radius;
		int d = 3 - 2 * radius;

		printPixel(x, y);

		while (x <= y)
		{
			x++;

			if (d > 0)
			{
				y--;
				d = d + 4 * (x - y) + 10;
			}
			else
			{
				d = d + 4 * x + 6;
			}

			printPixel(x, y);
		}
	}

public:
	

	/*int getRadius()
	{
		int r; 
		cin >> r;
		return r;
	}

	tuple<int, int> getCenter()
	{
		int x, y;
		cin >> x;
		cin >> y;

		tuple<int, int> center = make_tuple(x, y);

		return center;
	}*/

	int execute()
	{
		BresenhamCircle b;
		int numberOfTestCases = b.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = b.getTestCase(i);
			int radius = testCase[0];
			int x = testCase[1];
			int y = testCase[2];

			b.setRadius(radius);
			b.setCenter(x, y);
			b.getCircle();
		}

		return 0;
	}
};