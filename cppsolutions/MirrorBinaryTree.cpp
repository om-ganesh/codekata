#include <iostream>

using namespace std;

class MirrorBinaryTree
{
private:

	struct node
	{
		int value;
		node* left;
		node* right;
	};

	node* insertNode(int value)
	{
		node* n = new node;
		n->value = value;
		n->left = n->right = NULL;
		return(n);
	}

	bool isMirror(node* tree1, node* tree2)
	{
		if (tree1 == NULL && tree2 == NULL)
			return true;
		if (tree1 == NULL || tree2 == NULL)
			return false;

		return  tree1->value == tree2->value &&
			isMirror(tree1->left, tree2->right) &&
			isMirror(tree1->right, tree2->left);
	}

public:

	int execute()
	{
		// Tree 1:
		node* tree1 = insertNode(1);
		tree1->left = insertNode(2);
		tree1->right = insertNode(3);
		tree1->left->left = insertNode(4);
		tree1->left->right = insertNode(5);
		
		// Tree 2:
		node* tree2 = insertNode(1);
		tree2->left = insertNode(3);
		tree2->right = insertNode(2);
		tree2->right->left = insertNode(5);
		tree2->right->right = insertNode(4);

		bool result = isMirror(tree1, tree2);
		if (result)
		{
			cout << "Yes" << endl;
		}
		else
		{
			cout << "No";
		}

		delete tree1, tree2;
		return 0;
	}
};

