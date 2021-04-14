#include <vector>
#include <string>
#include <iostream>
#include <set>

using namespace std;

class FileNaming
{
private:
	vector<vector<string>> testCases
	{
		{"doc", "doc", "image", "doc(1)", "doc"}
	};

	vector<string> getTestCase(int index)
	{
		return testCases[index];
	}

	vector<string> fileNaming(vector<string> names)
	{
		set<string> fileNames;
		vector<string> output;

		for (int i = 0; i < names.size(); i++)
		{
			if (!(fileNames.find(names[i]) != fileNames.end()))
			{
				fileNames.insert(names[i]);
				output.push_back(names[i]);
			}
			else {
				
				int k = 0;
				string f = names[i];
				while (fileNames.find(f) != fileNames.end()) 
				{
					k++;
					f = names[i] + "(" + to_string(k) + ")";
				}

				fileNames.insert(f);
				output.push_back(f);
			}
		}
		return output;
	}

public:
	int execute()
	{
		FileNaming data;
		int numberOfTestCases = data.testCases.size();
		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<string> testCase = data.getTestCase(i);
			vector<string> results = data.fileNaming(testCase);
		}
		return 0;
	}
};