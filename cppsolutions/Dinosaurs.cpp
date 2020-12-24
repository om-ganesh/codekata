#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <algorithm>

using namespace std;

class DataSetStructure
{
public:
	string name;
	double length;
	string dietOrStance;
};

class DataSet
{
public:
	vector<DataSetStructure> dataSet;
};

class Dinosaurs
{

private:

	DataSetStructure parseString(string line)
	{
		DataSetStructure ds;

		if (line.size() != 0)
		{
			vector<char> cstr(line.c_str(), line.c_str() + line.size() + 1);

			int position[2];
			int k = 0;
			for (int i = 0; i < cstr.size(); i++)
			{
				if (cstr[i] == ',')
				{
					position[k++] = i;
				}
			}

			ds.name = line.substr(0, position[0]);
			ds.length = stod(line.substr(position[0] + 1, position[1] - position[0]));
			ds.dietOrStance = line.substr(position[1] + 1, line.size() - position[1]);
		}
		
		return ds;
	}

	DataSet readCSV(string fileName)
	{
		ifstream dsIn;
		dsIn.open(fileName);

		DataSetStructure data;
		DataSet ds;

		string line;
		int i = 0;

		while (!dsIn.eof())
		{
			getline(dsIn, line, '\n');
			if (i > 0)
			{
				data = parseString(line);
				if (!data.name.empty())
					ds.dataSet.push_back(data);
			}
			i++;
		}
		return ds;
	}

	vector<pair<double, string>> calculateSpeedAndMergeDataSets(DataSet ds1, DataSet ds2)
	{
		vector<pair<double, string>> results;

		int length = ds1.dataSet.size();
		double g = 9.81;

		for (int i = 0; i < length; i++)
		{
			string name = ds1.dataSet[i].name;
			string stance = ds2.dataSet[i].dietOrStance;
			double strideLength = ds2.dataSet[i].length;
			double legLength = ds1.dataSet[i].length;

			double speed;

			if (stance == "bipedal")
			{
				speed = (strideLength / legLength - 1) * sqrt(legLength * g);
				results.push_back(make_pair(speed, name));
			}
			
		}
		return results;
	}

public:
	int execute()
	{
		Dinosaurs d;
		DataSet ds1, ds2;
		vector<pair<double, string>> results;
		string dataSet1 = "DataSet1.csv";
		string dataSet2 = "DataSet2.csv";

		ds1 = d.readCSV(dataSet1);
		ds2 = d.readCSV(dataSet2);

		results = d.calculateSpeedAndMergeDataSets(ds1, ds2);
		sort(results.begin(), results.end());

		return 0;
	}
};