#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class MinimumProductionTime
{
private:

	vector<vector<int>> testCases{
		{3, 10, 2, 3, 2},
		{2, 5, 2, 3},
		{3, 10, 1, 3, 4},
		{3, 12, 4, 5, 6}
	};

	vector<int> getInput(int index)
	{
		return testCases[index];
	}

	int getQuickestOrSlowestTime(int length, int value, int goal)
	{
		int i = 0;
		while (length * i * value < goal)
		{
			i++;
		}
		return i * value;
	}

	double getFractionOfMachines(vector<int> machines)
	{
		double fraction = 0;

		for (int i = 0; i < machines.size(); i++)
		{
			fraction = fraction + 1.0 / machines[i];
		}
		return fraction;
	}

	int getMinimumProductionTime(vector<int> machines, int goal)
	{
		auto minmax = minmax_element(machines.begin(), machines.end());
		int min = *minmax.first;
		int max = *minmax.second;

		int quickestTime = getQuickestOrSlowestTime(machines.size(), min, goal);
		int slowestTime = getQuickestOrSlowestTime(machines.size(), max, goal);
	
		int days = quickestTime;
		while (getFractionOfMachines(machines) * days < goal)
		{
			days++;
		}
		return days;
	}

public:

	int execute()
	{
		MinimumProductionTime data;
		int numOfInput = data.testCases.size();

		for (int i = 0; i < numOfInput; i++)
		{
			vector<int> testCase = data.getInput(i);

			int n = testCase[0];
			int goal = testCase[1];
			vector<int> machines;
			copy(testCase.begin() + 2, testCase.end(), back_inserter(machines));

			cout << "Production Time = " << data.getMinimumProductionTime(machines, goal) << endl;
		}
		return 0;
	}
};