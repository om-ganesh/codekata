#include <iostream>
#include <vector>
#include <string>

using namespace std;

class AlphaPalindrome
{
private:

	vector<string> testCases
	{
		"!@!taat!",
		"N123a45^N"
	};

	string getInput(int index)
	{
		return testCases[index];
	}

	bool isPalindrom(string s)
	{
		bool result = false;
		string str = s;
		reverse(s.begin(), s.end());
		if (s == str)
			result = true;
		return result;
	}

	string removeNonAlphabetCharactersFromString(string s)
	{
		string str(s);
		s.erase(remove_if(s.begin(), s.end(), [](char c) { return !isalpha(c); }), s.end());
		return s;
	}

public:

	int execute()
	{
		AlphaPalindrome apdrom;
		int numberOfTestCases = apdrom.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			string inputStr = apdrom.getInput(i);
			string charOnlyStr = apdrom.removeNonAlphabetCharactersFromString(inputStr);
			bool isPalindrom = apdrom.isPalindrom(charOnlyStr);
			cout << "isPalindrome = " << isPalindrom << endl;
		}

		return 0;
	}
};