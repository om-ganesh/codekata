#include <iostream>
#include <vector>
#include <queue>
#include <stack>

using namespace std;

class GraphBFSAndDFS
{
private:

	vector<vector<int>> graphByAdjacentMatrixForBFS{
		{0, 1, 0, 1, 0, 0, 0},
		{0, 0, 1, 0, 0, 1, 0},
		{0, 0, 0, 0, 1, 0, 1},
		{0, 0, 0, 0, 0, 1, 0},
		{0, 1, 0, 0, 0, 1, 0},
		{1, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 1, 0, 0}
	};

	vector<vector<int>> graphByAdjacentMatrixForDFS{
		{0, 1, 0, 1, 0, 0, 0, 0},
		{0, 0, 1, 0, 0, 1, 0, 0},
		{0, 0, 0, 0, 1, 0, 1, 1},
		{0, 0, 0, 0, 0, 1, 0, 0},
		{0, 1, 0, 0, 0, 1, 0, 0},
		{1, 0, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 1, 0, 0, 1},
		{1, 0, 0, 0, 0, 0, 0, 0}
	};

	vector<int> statusVectorBFS{ 1, 1, 1, 1, 1, 1, 1 };
	vector<int> statusVectorDFS{ 1, 1, 1, 1, 1, 1, 1, 1 };

	void traverseNodesByBFS()
	{
		queue<int> visited;
		queue<int> adjacent;

		int startingNode = 0;

		visited.push(startingNode);
		statusVectorBFS[startingNode] = 3;

		for (int i = 0; i < graphByAdjacentMatrixForBFS.size(); i++)
		{
			if (graphByAdjacentMatrixForBFS[startingNode][i] == 1)
			{
				adjacent.push(i);
				statusVectorBFS[i] = 2;
			}
		}

		while (!adjacent.empty())
		{
			int node = adjacent.front();
			visited.push(node);
			statusVectorBFS[node] = 3;
			adjacent.pop();

			for (int i = 0; i < graphByAdjacentMatrixForBFS.size(); i++)
			{
				if (graphByAdjacentMatrixForBFS[node][i] == 1 && statusVectorBFS[i] == 1)
				{
					adjacent.push(i);
					statusVectorBFS[i] = 2;
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
		stack<int> dfsStack;

		int startingNode = 7;

		dfsStack.push(startingNode);
		statusVectorDFS[startingNode] = 2;

		while (!dfsStack.empty())
		{
			int printNode = dfsStack.top();
			cout << printNode << " ";
			statusVectorDFS[printNode] = 3;
			dfsStack.pop();

			for (int i = 0; i < statusVectorDFS.size(); i++)
			{
				if (graphByAdjacentMatrixForDFS[printNode][i] == 1 && statusVectorDFS[i] == 1)
				{
					dfsStack.push(i);
					statusVectorDFS[i] = 2;
				}
			}

		}

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