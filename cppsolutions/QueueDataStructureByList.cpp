#include <iostream>
#include <list>

using namespace std;

class QueueDataStructureByList
{
private:
	list<int> intQueue;
	
	void addToQueue(int value)
	{
		intQueue.push_back(value);
	}

	void removeFromQueue(int times)
	{
		for (int i = 0; i < times; i++)
		{
			if (!intQueue.empty())
			{
				intQueue.pop_front();
			}
		}
	}

	void printQueue()
	{
		for (int& i : intQueue)
		{
			cout << i << " ";
		}
		cout << endl;
	}

public:
	int execute()
	{
		QueueDataStructureByList queue;

		int n = 10;
		for (int i = 0; i < n; i++)
		{
			queue.addToQueue(rand() % 10);
		}

		queue.printQueue();
		queue.removeFromQueue(4);
		queue.printQueue();

		return 0;
	}
};