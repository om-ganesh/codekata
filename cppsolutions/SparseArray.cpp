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

class SparseArray
{
    // Complete the matchingStrings function below.
    vector<int> matchingStrings(vector<string> strings, vector<string> queries) {

        int qLength = queries.size();
        vector<int> countArray;

        for (int i = 0; i < qLength; i++)
        {
            int ct = count(strings.begin(), strings.end(), queries[i]);
            countArray.push_back(ct);
        }

        return countArray;
    }

public:

    int execute()
    {
        // ofstream fout(getenv("OUTPUT_PATH"));
        ofstream fout("OUTPUT_PATH");

        int strings_count;
        cin >> strings_count;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        vector<string> strings(strings_count);

        for (int i = 0; i < strings_count; i++) {
            string strings_item;
            getline(cin, strings_item);

            strings[i] = strings_item;
        }

        int queries_count;
        cin >> queries_count;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        vector<string> queries(queries_count);

        for (int i = 0; i < queries_count; i++) {
            string queries_item;
            getline(cin, queries_item);

            queries[i] = queries_item;
        }

        vector<int> res = matchingStrings(strings, queries);

        for (int i = 0; i < res.size(); i++) {
            fout << res[i];

            if (i != res.size() - 1) {
                fout << "\n";
            }
        }

        fout << "\n";

        fout.close();

        return 0;
    }

};
