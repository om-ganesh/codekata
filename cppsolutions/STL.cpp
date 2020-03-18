#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

class STL
{
public:
    int execute() {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        int n, d, q;
        cin >> n;
        vector<int> arr;
        for (int i = 0; i < n; i++)
        {
            cin >> d;
            arr.push_back(d);
        }
        cin >> q;

        for (int j = 0; j < q; j++)
        {
            cin >> d;

            vector<int>::iterator low, up;
            low = lower_bound(arr.begin(), arr.end(), d);
            up = upper_bound(arr.begin(), arr.end(), d);

            if ((low - arr.begin()) == (up - arr.begin()))
            {
                int index = up - arr.begin();
                cout << "No " << index + 1 << endl;
            }
            else
            {
                int index = low - arr.begin();
                cout << "Yes " << index + 1 << endl;
            }

        }
        return 0;
    }
};

