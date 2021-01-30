#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;

class FindWriter
{
private:
    vector<string> testData
    {
        "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg | 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53"
    };

    string getTestData(int index)
    {
        return testData[index];
    }

    // Finding the writer:
    // We have 0 based index in general, however, in the problem
    // they used 1 based index for the "Key" array.
    // For example: S is given by [3] from substring osS.
    // In C++ convention, it should have been [0] = o, [1] = s and [2] = S
    // That is why I subtracted 1 from the index in line 21:

    string findWriter(string data, vector<int> positions)
    {
        string name;
        int length = positions.size();

        for (int i = 0; i < length; i++)
        {
            name.push_back(data[positions[i] - 1]);
        }
        return name;
    }

    // Parsing string to int
    vector<int> positionArray(string line)
    {
        stringstream stream(line);
        vector<int> out;
        while (1)
        {
            int number;
            stream >> number;
            if (!stream)
            {
                break;
            }
            out.push_back(number);
        }
        return out;
    }

public:
    
    int execute() {

        FindWriter data;
        int numberOfTestCases = data.testData.size();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            string line = data.getTestData(i);
            // Finding separating pipe character's position
            int pipePosition = line.find('|');
            // Finding total length
            int lineLength = line.length();
            // Separating name and key subarrays
            string name = line.substr(0, pipePosition);
            string key = line.substr(pipePosition + 1, lineLength);
            // Converting key from string to int
            vector<int> data = positionArray(key);

            // Finding the name of the writer
            string writersName = findWriter(name, data);
            cout << writersName << endl;
        }

        return 0;
    }
};





