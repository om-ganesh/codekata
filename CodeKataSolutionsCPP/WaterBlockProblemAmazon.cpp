#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

class Data {

    vector<int> data{ 0,1,0,2,1,0,1,3,2,1,2,1 }; // 6
    // vector<int> data{ 0,0,2,0,1,0,2,0,3,0,1,1 }; // 8
    // vector<int> data{ 0,0,4,0,1,0,2,0,3,0,1,1,4 }; // 28
    // vector<int> data{ 1,2,3,4,3,2,1,1,2,3,4 }; // 12
    // vector<int> data{ 0,0,0,1,1,0,0 }; // 0
    // vector<int> data{ 5,0,0 }; // 0
    // vector<int> data{ 0,2 }; // 0
    // vector<int> data{ 1 }; // 0
    // vector<int> data{ 0,0,3,0 }; // 0
    // vector<int> data{ 1,2,3,2,1 }; // 0
    // vector<int> data{ 3,2,1,0,1,2 }; // 4
    // vector<int> data{ 3,2,3,2,3,2 }; // 2
    
    
    public: 

    // Just pass the test data 
    vector<int> GetTestData()
    {
        return data;
    }
    
    int GetHighestTowards(string bound, int fromIndex)
    {
        int highestValue;
        
        // Set up left bound or right bound
        int left = bound.compare("left");
        int right = bound.compare("right");
        int from, to;
        
        if (left == 0)
        {
            from = 0;
            to = fromIndex;
        }
            
        if (right == 0)
        {
            from = fromIndex + 1;
            to = data.size();
        }
        
        // Chopping down to sub-array/vector:
        vector<int> temp(&data[from], &data[to]);
        
        // Getting max value from the sub-array:
        highestValue = *max_element(temp.begin(), temp.end());
        
        return highestValue;
    }
};

int main (void)
{
    vector<int> a;
    Data d;
    a = d.GetTestData();
    
    int leftHighest, rightHighest, minOfTwo;
    int sum = 0;
    
    // start from index 1 and go until length-1
    for (int i = 1; i < a.size() - 1; i++)
    {
        // Get highest values towards left and right:
        leftHighest = d.GetHighestTowards("left", i);
        rightHighest = d.GetHighestTowards("right", i);
        
        // Get minimum of two highest values:
        int minOfTwo = min(leftHighest, rightHighest);
        
        // If the current index is zero then it can store minOfTwo amount of water
        // If not then the current index value should be subtracted from minOfTwo:
        if (a[i] == 0)
        {
            sum += minOfTwo;
        }
        else
        {
            if ((minOfTwo-a[i]) > 0)
                sum += minOfTwo-a[i];
        }
    }
    
    cout << "total Unit of Water: " << sum;

    return 0;
}