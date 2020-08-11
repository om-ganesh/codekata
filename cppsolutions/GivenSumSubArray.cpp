#include <iostream>
#include <vector>

using namespace std;

class GivenSumSubArray
{
    vector<int> a;

public:

    vector<int> generateData(int idx)
    {
        vector<vector<int>> testCases{ 
            { 1, 2, 3, 7, 5 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
        };
        
        return testCases[idx];
    }

    void printData()
    {
        int length = a.size();
        for (int i = 0; i < length; i++)
        {
            cout << a[i] << " ";
        }
        cout << endl;
    }

    vector<int> findSubArrayWithGivenSum(int s)
    {
        vector<int> result;

        int firstIndex = 0;
        int lastIndex = 0;
        int nextIndex = 0;
        int sum = 0;
        int i = 0;
        bool sumNotFound = true;

        while (sumNotFound)
        {
            sum += a[i];
            
            if (sum == s)
            {
                sumNotFound = false;
                lastIndex = i;
            }

            if (sum > s)
            {
                firstIndex = ++nextIndex;
                sum = a[firstIndex];
                i = firstIndex;
            }

            i++;
        }

        result.push_back(firstIndex);
        result.push_back(lastIndex);

        return result;
    }

    int execute() {

        GivenSumSubArray data;
        vector<int> res;
        data.a = data.generateData(1);
        data.printData();
        int sum = 15;
        res = data.findSubArrayWithGivenSum(sum);
        cout << "Sum is Found in SubArray From Index " << res[0] << " to Index " << res[1] << endl;
        return 0;
    }
};


