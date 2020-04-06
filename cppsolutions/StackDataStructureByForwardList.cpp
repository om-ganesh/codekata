// In a stack, the first input goes to the bottom of the stack.
// When printed, it's printed from top of the stack to bottom, for the remaining elements.

#include <iostream>
#include <forward_list>

using namespace std;

class StackDataStructureByForwardList
{
private:

	forward_list<int> intStack;

	void pushToStack(int value)
	{
		intStack.push_front(value);
	}
	
	void popFromStack(int times)
	{
		for (int i = 0; i < times; i++)
		{
			if (!intStack.empty())
				intStack.pop_front();
		}
	}

	void printStack()
	{
		for (int &i : intStack)
		{
			cout << i << " ";
		}
		cout << endl;
	}

public:
	int execute()
	{
		StackDataStructureByForwardList linkedList;

		int n = 10;
		for (int i = 0; i < n; i++)
		{
			linkedList.pushToStack(rand() % 10);
		}

		linkedList.printStack();

		linkedList.popFromStack(4);

		linkedList.printStack();
		return 0;
	}
};