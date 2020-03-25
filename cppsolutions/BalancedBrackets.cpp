#include <vector>
#include <string>
#include <fstream>
#include <conio.h>
#include <iostream>
#include <stdlib.h>
#include <algorithm>
#include <numeric>
#include <iterator>
#include <functional>

using namespace std;

class BalancedBrackets {
    // Complete the isBalanced function below.
    string isBalanced(string s) {

        string returnValue = "";
        bool flag = false;

        vector<char> stack;
        int length = s.length();

        for (int i = 0; i < length; i++)
        {
            flag = false;
            if (s[i] == '{' || s[i] == '[' || s[i] == '(')
            {
                stack.push_back(s[i]);
            }
            if (s[i] == '}' || s[i] == ']' || s[i] == ')')
            {
                if (i > 0)
                {
                    char lastItemInStack = stack.back();
                    stack.pop_back();
                    if (lastItemInStack == '{')
                        lastItemInStack = '}';
                    if (lastItemInStack == '[')
                        lastItemInStack = ']';
                    if (lastItemInStack == '(')
                        lastItemInStack = ')';
                    if (lastItemInStack == s[i])
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }

                }
                if (i == 0)
                    break;
            }
        }
        if (flag)
            returnValue = "YES";
        else
            returnValue = "NO";

        return returnValue;
    }

public:

    int execute()
    {
        // ofstream fout(getenv("OUTPUT_PATH"));
        ofstream fout("OUTPUT_PATH");

        int t;
        cin >> t;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        for (int t_itr = 0; t_itr < t; t_itr++) {
            string s;
            getline(cin, s);

            string result = isBalanced(s);

            fout << result << "\n";
        }

        fout.close();

        return 0;
    }
};
