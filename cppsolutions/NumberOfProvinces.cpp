#include <iostream>
#include <vector>
#include <stack>

using namespace std;

class NumberOfProvinces
{
private:
	vector<vector<vector<int>>> testCases{
		{
			{1,1,0}, 
			{1,1,0}, 
			{0,0,1}
		},
		{
			{1,0,0},
			{0,1,0},
			{0,0,1}
		}

	};

	vector<vector<int>> getInput(int index)
	{
		return testCases[index];
	}

	bool contains(vector<int> data, int item)
	{
		vector<int>::iterator it = find(data.begin(), data.end(), item);
		if (it != data.end())
			return true;
		else
			return false;
	}

	void vectorToStack(vector<int> input, stack<int>* output, int skipNode)
	{
		for (int i = 0; i < input.size(); i++)
		{
			if (input[i] != 0 && (i+1) != skipNode)
				output->push(i+1);
		}
	}

	int getNumberOfProvinces(vector<vector<int>> matrix)
	{
		int numberOfProvinces = 0;
		int numberOfTotalNodes = matrix.size();
		vector<int> visitedNodes;
		stack<int> neighboringNodes;

		for (int i = 0; i < numberOfTotalNodes; i++)
		{
			int currentNode = i + 1;
			if (!contains(visitedNodes, currentNode))
			{
				visitedNodes.push_back(currentNode);

				vector<int> adjacentNodes = matrix[i];
				vectorToStack(adjacentNodes, &neighboringNodes, currentNode);

				while (!neighboringNodes.empty())
				{
					currentNode = neighboringNodes.top();
					neighboringNodes.pop();

					if (!contains(visitedNodes, currentNode))
					{
						visitedNodes.push_back(currentNode);
						adjacentNodes = matrix[currentNode - 1];
						vectorToStack(adjacentNodes, &neighboringNodes, currentNode);
					}
				}

				numberOfProvinces++;

			}
			
		}
		return numberOfProvinces;
	}

public:
	int execute()
	{
		NumberOfProvinces data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<vector<int>> testCase = data.getInput(i);
			cout << "Number of Provinces: " << data.getNumberOfProvinces(testCase) << endl;
		}
		return 0;
	}
};