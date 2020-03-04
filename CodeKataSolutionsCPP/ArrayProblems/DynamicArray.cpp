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
#include <vector>

using namespace std;

string ltrim1(const string& str) {
    string s(str);

    s.erase(
        s.begin(),
        find_if(s.begin(), s.end(), not1(ptr_fun<int, int>(isspace)))
    );

    return s;
}

string rtrim1(const string& str) {
    string s(str);

    s.erase(
        find_if(s.rbegin(), s.rend(), not1(ptr_fun<int, int>(isspace))).base(),
        s.end()
    );

    return s;
}

vector<string> split1(const string& str) {
    vector<string> tokens;

    string::size_type start = 0;
    string::size_type end = 0;

    while ((end = str.find(" ", start)) != string::npos) {
        tokens.push_back(str.substr(start, end - start));

        start = end + 1;
    }

    tokens.push_back(str.substr(start));

    return tokens;
}


class DynamicArray
{

public:
    int execute()
    {

        string first_multiple_input_temp;
        getline(cin, first_multiple_input_temp);

        vector<string> first_multiple_input = split1(rtrim1(first_multiple_input_temp));

        int n = stoi(first_multiple_input[0]);

        int q = stoi(first_multiple_input[1]);

        vector<vector<int>> queries(q);

        for (int i = 0; i < q; i++) {
            queries[i].resize(3);

            string queries_row_temp_temp;
            getline(cin, queries_row_temp_temp);

            vector<string> queries_row_temp = split1(rtrim1(queries_row_temp_temp));

            for (int j = 0; j < 3; j++) {
                int queries_row_item = stoi(queries_row_temp[j]);

                queries[i][j] = queries_row_item;
            }
        }

        vector<int> result = dynamicArray(n, queries);

        for (int i = 0; i < result.size(); i++) {
            cout << result[i];

            if (i != result.size() - 1) {
                cout << "\n";
            }
        }

        cout << "\n";

        

        return 0;
    }

private:
    vector<int> dynamicArray(int n, vector<vector<int>> queries) {
        vector<int> results;
        vector<vector<int>> dynamic2DArray;

        for (int i = 0; i < n; i++)
        {
            vector<int> temp;
            dynamic2DArray.push_back(temp);
        }

        int numberOfQueries = queries.size();
        int lastAnswer = 0;

        for (int i = 0; i < numberOfQueries; i++)
        {
            int type, x, y, index;
            type = queries[i][0];
            x = queries[i][1];
            y = queries[i][2];

            if (type == 1)
            {
                index = (x ^ lastAnswer) % n;
                dynamic2DArray[index].push_back(y);
            }
            if (type == 2)
            {

                index = (x ^ lastAnswer) % n;
                int sz = dynamic2DArray[index].size();

                int at = y % sz;
                lastAnswer = dynamic2DArray[index][at];
            }
            if (lastAnswer)
                results.push_back(lastAnswer);
        }
        return results;
    }

};
