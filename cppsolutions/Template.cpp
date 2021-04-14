#include <vector>
#include <string>
#include <iostream>

using namespace std;

class Template
{
private:
	vector<string> testCases
	{

	};

	string getTestCase(int index)
	{
		return testCases[index];
	}

	int solveProblem(string input)
	{

	}

public:
	int execute()
	{
		Template data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = data.getTestCase(i);
			cout << data.solveProblem(testCase) << endl;
		}
		return 0;
	}
};