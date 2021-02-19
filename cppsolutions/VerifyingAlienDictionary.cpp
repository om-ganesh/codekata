#include <vector>
#include <string>
#include <iostream>
#include <algorithm>

using namespace std;

class VerifyingAlienDictionary
{

private:

	vector<vector<string>> testCases
	{
		{"hello", "leetcode", "hlabcdefgijkmnopqrstuvwxyz"},
		{"word", "world", "row", "worldabcefghijkmnpqstuvxyz"},
		{"apple", "app", "abcdefghijklmnopqrstuvwxyz"}
	};

	vector<string> getTestCases(int index)
	{
		return testCases[index];
	}

	vector<string> getWords(vector<string> testCase)
	{
		int testCaseSize = testCase.size();
		vector<string> words;
		for (int i = 0; i < testCaseSize - 1; i++)
		{
			words.push_back(testCase[i]);
		}
		return words;
	}

	string getOrder(vector<string> testCase)
	{
		int testCaseSize = testCase.size();
		string order;
		order = testCase[testCaseSize - 1];
		return order;
	}

	bool verifyDictionary(vector<string> words, string order)
	{
		// Find position of human letter
		// Translate alient words to human words
		return is_sorted(words.begin(), words.end());
	}

public:
	int execute()
	{
		VerifyingAlienDictionary data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<string> testCase = data.getTestCases(i);
			
			vector<string> words = data.getWords(testCase);
			string order = data.getOrder(testCase);

			cout << data.verifyDictionary(words, order) << endl;
		}
		return 0;
	}
};