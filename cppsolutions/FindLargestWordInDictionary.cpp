#include <vector>
#include <algorithm>
#include <iostream>
#include <string>

using namespace std;

class FindLargestWordInDictionary
{
private:

	vector<string> dictionary;
	string stringToSearch;

	vector<string> getDictionary(int idx)
	{
		vector<vector<string>> allWords{
			{"ale", "apple", "monkey", "plea"},
			{"pintu", "geeksfor", "geeksgeeks", "forgeek"}
		};
		return allWords[idx];
	}

	bool isSubsequence(string str1, string str2)
	{
		bool finding = false;
		int j = 0;
		for (int i = 0; i < str2.length(); i++)
		{
			if (str2[i] == str1[j])
				j++;
		}
		if (j == str1.length())
			finding = true;
		return finding;
	}
public:
	int execute()
	{
		FindLargestWordInDictionary data;
		data.dictionary = data.getDictionary(0);
		data.stringToSearch = "abpcplea";
		// data.stringToSearch = "geeksforgeeks";
		int maxLength = 0;
		string resultString = "";
		for (int i = 0; i < data.dictionary.size(); i++)
		{
			if (isSubsequence(data.dictionary[i], data.stringToSearch))
			{
				if (data.dictionary[i].length() > maxLength)
				{
					maxLength = data.dictionary[i].length();
					resultString = data.dictionary[i];
				}
			}
		}

		cout << resultString;
		
		return 0;
	}
};