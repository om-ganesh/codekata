#include <iostream>
#include <vector>

using namespace std;

class ListNode
{
public:
	int value;
	ListNode* next;
};

class LinkedListBasicOperations
{
private:

	vector<vector<int>> testCases
	{
		{1, 2, 3, 4, 5},
		{4, 5, 7, 1, -5, 6}
	};

	vector<int> getTestCase(int index)
	{
		return testCases[index];
	}

	ListNode* convertArrayToLinkedList(vector<int> arr)
	{
		ListNode* head = new ListNode();
		ListNode* current = head;

		for (int i = 0; i < arr.size(); i++)
		{
			current->value = arr[i];

			if (i == arr.size() - 1)
			{
				current->next = NULL;
			}
			else
			{
				ListNode* nextNode = new ListNode();
				current->next = nextNode;
				current = current->next;
			}
		}
		return head;
	}

	void printLinkedList(ListNode* head)
	{
		ListNode* current = head;

		while (current != NULL)
		{
			cout << current->value << " ";
			current = current->next;
		}
		cout << endl;
	}

public:
	int execute()
	{
		LinkedListBasicOperations data;
		int numberOfTestCases = data.testCases.size();

		for (int i = 0; i < numberOfTestCases; i++)
		{
			vector<int> testCase = data.getTestCase(i);
			ListNode* head = data.convertArrayToLinkedList(testCase);
			data.printLinkedList(head);
		}

		return 0;
	}
};