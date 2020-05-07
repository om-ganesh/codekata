#include <iostream>
#include <vector>

using namespace std;

struct Coordinate {
	float x;
	float y;
};

class BoundaryCheck 
{

private:

	Coordinate coordinate;
	Coordinate center;
	const float heightOfRectangle = 1080.0;
	const float widthOfRectangle = 1920.0;
	const float diameterOfCircle = 1920.0;

	vector<Coordinate> testCases{
		{coordinate.x = 10, coordinate.y = 20 },
		{coordinate.x = 25, coordinate.y = 56 },
		{coordinate.x = -25, coordinate.y = 56 },
		{coordinate.x = 500, coordinate.y = 600 },
	};
	
	bool isPointWithinIntersection(Coordinate point)
	{
		if (isPointWithinRectangle(point) && isPointWithinCircle(point))
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	bool isPointWithinRectangle(Coordinate point)
	{
		bool found = false;
		bool checXCoordinate = point.x >= 0 && point.x <= widthOfRectangle;
		bool checYCoordinate = point.y >= 0 && point.y <= heightOfRectangle;
		if (checXCoordinate && checYCoordinate)
		{
			found = true;
		}
		return found;
	}

	bool isPointWithinCircle(Coordinate point)
	{
		bool found = false;
		float radiusOfCircle = diameterOfCircle / 2.0;
		center.x = widthOfRectangle / 2.0;
		center.y = heightOfRectangle / 2.0;
		float xDiff = point.x - center.x;
		float yDiff = point.y - center.y;

		if (xDiff * xDiff + yDiff * yDiff <= radiusOfCircle * radiusOfCircle)
		{
			found = true;
		}
		return found;
	}

	Coordinate getTestDataPoints(int index)
	{
		return testCases[index];
	}

public:

	int execute()
	{
		BoundaryCheck dataPoint;
		int numberOfTestCases = dataPoint.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			dataPoint.coordinate = dataPoint.getTestDataPoints(i);
			bool answer = dataPoint.isPointWithinIntersection(dataPoint.coordinate);
			cout << answer << endl;
		}

		return 0;
	}

};