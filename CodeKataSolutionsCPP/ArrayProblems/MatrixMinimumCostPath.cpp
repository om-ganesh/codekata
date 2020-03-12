#include <iostream>
#include <vector>
#include <string>
#include <algorithm> 

using namespace std;

class Data 
{
	vector<vector<int>> Mat;
	
	public:
   
	vector<vector<int>> GetAMatrix(int m, int n)
	{
	   for (int i = 0; i < m; i++)
		{
			vector<int> temp;
			for (int j = 0; j < n; j++)
			{
				int randomValue = rand() % 100;
				temp.push_back(randomValue);
			}
			Mat.push_back(temp);
		}
		
		return Mat;
	}
   
   void PrintAMatrix(vector<vector<int>> &Mat, int m, int n)
   {
	   cout << "Printing Matrix:" << endl;
	   for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				cout << Mat[i][j] << " ";
			}
			cout << endl;
		}
   }

};

int main()
{
    Data d;
	int row = 4;
	int col = 4;
	vector<vector<int>> matrix;
	vector<vector<int>> temporaryCostMatrix;
	vector<int> minimumCostPath;
	
	matrix = d.GetAMatrix(row, col);
	
	d.PrintAMatrix(matrix, row, col);
  
	int cost = matrix[0][0];
	vector<int> temporaryCostRow;
  
	// Generating First Row in Cost Matrix
	temporaryCostRow.push_back(cost);
	for (int i = 1; i < col; i++)
	{
		cost = cost + matrix[0][i];
		temporaryCostRow.push_back(cost);
	}
	temporaryCostMatrix.push_back(temporaryCostRow);
  
	// Generating First Column in Cost Matrix
	cost = temporaryCostMatrix[0][0];
	for (int i = 1; i < row; i++)
	{
		vector<int> temporaryCostCol;
		cost = cost + matrix[i][0];
		temporaryCostCol.push_back(cost);
		temporaryCostMatrix.push_back(temporaryCostCol);
	}
  
	//d.PrintAMatrix(temporaryCostMatrix, row, col);
  
	// Generating Rest of the elements.
	for (int i = 1; i < row; i++)
	{
		fill(temporaryCostRow.begin()+1, temporaryCostRow.end(), 0);
		for (int j = 1; j < col; j++)
		{
			cost = matrix[i][j] + min(temporaryCostMatrix[i-1][j], temporaryCostMatrix[i][j-1]);
			temporaryCostMatrix[i][j] = cost;
		}
	}
  
	//d.PrintAMatrix(temporaryCostMatrix, row, col);
  
	minimumCostPath.push_back(row-1);
	minimumCostPath.push_back(col-1);
	bool flag = true;
	int i = row-1;
	int j = col-1;
	while(flag)
	{
		if (min(temporaryCostMatrix[i-1][j], temporaryCostMatrix[i][j-1]) == temporaryCostMatrix[i-1][j] && flag)
		{
			minimumCostPath.push_back(i-1);
			minimumCostPath.push_back(j); 
			i = i-1;
			if (i == 0)
			{
				minimumCostPath.push_back(i);
				minimumCostPath.push_back(0);
				flag = false;
				break;
			}   
		}
		
		if (min(temporaryCostMatrix[i-1][j], temporaryCostMatrix[i][j-1]) == temporaryCostMatrix[i][j-1] && flag)
		{
			minimumCostPath.push_back(i);
			minimumCostPath.push_back(j-1);
			j = j-1;
			if (j == 0)
			{
				minimumCostPath.push_back(0);
				minimumCostPath.push_back(j);
				flag = false;
				break;
			}  
		}
       
	}
  
	cout << "Minimum Cost Path: " << endl;
	for (int i = 0; i < minimumCostPath.size(); i=i+2)
	{
		cout << "(" << minimumCostPath[i] << ", " << minimumCostPath[i+1] << ")";
		if (i < minimumCostPath.size()-2)
			cout << " <-- ";
	}  
}

