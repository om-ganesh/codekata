#include <vector>
#include <string>
#include <iostream>

using namespace std;

class LongestWord
{
private:
	vector<string> testCases
	{
		"aa bbb ccc dddd eeeee",
		"A!! AA[]z",
		"ab-CDE-fg_hi"
	};

	string getTestCase(int index)
	{
		return testCases[index];
	}

    string removeNonAlphaCharacters(string input)
    {
        string output;
        for (int i = 0; i < input.length(); i++)
        {
            if (isalpha(input[i]) || input[i] == ' ')
            {
                output.push_back(input[i]);
            }
            else
            {
                output.push_back(' ');
            }
        }
        return output;
    }

    string longestWord(string text) {

        text = removeNonAlphaCharacters(text);

        string maxString;
        int init_pos = 0;
        int max_length = 0;
        bool singleWord = true;
        int i;
        for (i = 0; i < text.length(); i++)
        {
            if (text[i] == ' ')
            {
                singleWord = false;
                string st = text.substr(init_pos, i - init_pos);
                if (st.length() > max_length)
                {
                    max_length = st.length();
                    maxString = st;
                }
                init_pos = i + 1;
            }
        }

        string st = text.substr(init_pos, i - init_pos);
        if (st.length() > max_length)
        {
            max_length = st.length();
            maxString = st;
        }

        if (singleWord)
            maxString = text;
        return maxString;
    }


public:
	int execute()
	{
		LongestWord data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = data.getTestCase(i);
            cout << data.longestWord(testCase) << endl;
		}
		return 0;
	}
};