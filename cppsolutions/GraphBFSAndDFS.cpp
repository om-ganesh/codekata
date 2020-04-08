#include <iostream>
#include <vector>
#include <queue>
#include <stack>

using namespace std;

class GraphBFSAndDFS
{
private:

	vector<vector<int>> graphByAdjacentMatrix{
		{0, 1, 0, 1, 0, 0, 0},
		{0, 0, 1, 0, 0, 1, 0},
		{0, 0, 0, 0, 1, 0, 1},
		{0, 0, 0, 0, 0, 1, 0},
		{0, 1, 0, 0, 0, 1, 0},
		{1, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 1, 0, 0} 
	};

	void traverseNodesByBFS()
	{
		queue<int> visited;
		queue<int> adjacent;

		int startingNode = 0;

		visited.push(startingNode);

	}

	void traverseNodesByDFS()
	{

	}

public:
	int execute()
	{
		GraphBFSAndDFS gbad;
		gbad.traverseNodesByBFS();
		gbad.traverseNodesByDFS();
		return 0;
	}
};