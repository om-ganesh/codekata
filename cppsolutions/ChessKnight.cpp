#include <string>
#include <iostream>
#include <vector>

using namespace std;

class ChessKnight
{
private:
	vector<string> testCases
	{
		"a1",
		"c2",
		"d4"
	};

	string getTestCase(int index)
	{
		return testCases[index];
	}

	vector<string> getUpDownLeftRightCells(char letter, int number)
	{
		vector<string> udlr;

		// string up = number + 2 <= 8 ? letter + to_string(number + 2) : "";
		// string down = number - 2 >= 1 ? letter + to_string(number - 2) : "";
		// string left = letter - 2 >= 97 ? char(letter - 2) + to_string(number) : "";
		// string right = letter + 2 <= 104 ? char(letter + 2) + to_string(number) : "";

		udlr.push_back(number + 2 <= 8 ? letter + to_string(number + 2) : "");          // up cell
		udlr.push_back(number - 2 >= 1 ? letter + to_string(number - 2) : "");          // down cell
		udlr.push_back(letter - 2 >= 97 ? char(letter - 2) + to_string(number) : "");   // left cell
		udlr.push_back(letter + 2 <= 104 ? char(letter + 2) + to_string(number) : "");  // right cell

		return udlr;
	}

    vector<string> getleftRightCells(char letter, int number)
    {
        vector<string> lr;

        lr.push_back(letter - 1 >= 97 ? char(letter - 1) + to_string(number) : "");   // left cell
        lr.push_back(letter + 1 <= 104 ? char(letter + 1) + to_string(number) : "");  // right cell

        return lr;
    }

    vector<string> getUpDownCells(char letter, int number)
    {
        vector<string> ud;

        ud.push_back(number + 1 <= 8 ? letter + to_string(number + 1) : "");          // up cell
        ud.push_back(number - 1 >= 1 ? letter + to_string(number - 1) : "");          // down cell

        return ud;
    }

    int chessKnight(string cell) {

        char letter = cell[0];
        int number = cell[1] - 48;


        vector<string> cells = getUpDownLeftRightCells(letter, number);

        /*cout << cells[0] << endl;
        cout << cells[1] << endl;
        cout << cells[2] << endl;
        cout << cells[3] << endl;*/

        int cellCount = 0;

        for (int i = 0; i < cells.size(); i++)
        {
            // up and down cells
            string st = cells[i];
            if (i < 2)
            {
                if (!empty(st))
                {
                    vector<string> leftRight = getleftRightCells(st[0], st[1]-48);
                    if (!empty(leftRight[0]))
                    {
                        cellCount++;
                    }
                    if (!empty(leftRight[1]))
                    {
                        cellCount++;
                    }
                }
            }
            // left and right cells
            else {
                if (!empty(st))
                {
                    vector<string> upDown = getUpDownCells(st[0], st[1]-48);
                    if (!empty(upDown[0]))
                    {
                        cellCount++;
                    }
                    if (!empty(upDown[1]))
                    {
                        cellCount++;
                    }
                }
            }
        }

        return cellCount;
    }

public:

	int execute()
	{
		ChessKnight data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			string testCase = data.getTestCase(i);
            cout << data.chessKnight(testCase) << endl;
		}
		return 0;
	}
};