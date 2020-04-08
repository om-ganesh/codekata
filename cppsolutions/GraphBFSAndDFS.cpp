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

	vector<int> statusVector{1, 1, 1, 1, 1, 1, 1};

	void traverseNodesByBFS()
	{
		queue<int> visited;
		queue<int> adjacent;

		int startingNode = 0;

		visited.push(startingNode);
		statusVector[startingNode] = 3;

		for (int i = 0; i < graphByAdjacentMatrix.size(); i++)
		{
			if (graphByAdjacentMatrix[startingNode][i] == 1)
			{
				adjacent.push(i);
				statusVector[i] = 2;
			}
		}

		while (!adjacent.empty())
		{
			int node = adjacent.front();
			visited.push(node);
			statusVector[node] = 3;
			adjacent.pop();

			for (int i = 0; i < graphByAdjacentMatrix.size(); i++)
			{
				if (graphByAdjacentMatrix[node][i] == 1 && statusVector[i] == 1)
				{
					adjacent.push(i);
					statusVector[i] = 2;
				}
			}
		}

		printBFSOrder(visited);
	}

	void printBFSOrder(queue<int> traversedNodes)
	{
		while (!traversedNodes.empty())
		{
			cout << traversedNodes.front() << " ";
			traversedNodes.pop();
		}
		cout << endl;
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