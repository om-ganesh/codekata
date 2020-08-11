// Since it is implemented using pointers, it is important to use destructor to free up the used memory.
// That is why we need constructor and destructor as a must here.
// Also, in order to use pointers, we need to use struct for node, instead of class.
// Not sure why I need to make all the functions inline to work.

#include <iostream>

using namespace std;

struct node
{
	int value;
	node *left;
	node *right;
};

class BinaryTreeExample
{
private:
	node* root;

	void destroyTree(node* leaf)
	{
		if (leaf != NULL)
		{
			destroyTree(leaf->left);
			destroyTree(leaf->right);
			delete leaf;
		}
	}
	void insertKey(int key, node* leaf)
	{
		if (key < leaf->value)
		{
			if (leaf->left != NULL)
			{
				insertKey(key, leaf->left);
			}
			else
			{
				leaf->left = new node;
				leaf->left->value = key;
				leaf->left->left = NULL;
				leaf->left->right = NULL;
			}
		}
		else if (key >= leaf->value)
		{
			if (leaf->right != NULL)
			{
				insertKey(key, leaf->right);
			}
			else
			{
				leaf->right = new node;
				leaf->right->value = key;
				leaf->right->right = NULL;
				leaf->right->left = NULL;
			}
		}
	}
	node* search(int key, node* leaf)
	{
		if (leaf != NULL)
		{
			if (key == leaf->value)
			{
				return leaf;
			}
			if (key < leaf->value)
			{
				return search(key, leaf->left);
			}
			else
			{
				return search(key, leaf->right);
			}
		}
		else
		{
			return NULL;
		}
	}

	void printInOrder(node* leaf)
	{
		if (leaf != NULL)
		{
			printInOrder(leaf->left);
			cout << leaf->value << ",";
			printInOrder(leaf->right);
		}
	}

	void printPreOrder(node* leaf)
	{
		if (leaf != NULL)
		{
			cout << leaf->value << ",";
			printInOrder(leaf->left);
			printInOrder(leaf->right);
		}
	}
	void printPostOrder(node* leaf)
	{
		if (leaf != NULL)
		{
			printInOrder(leaf->left);
			printInOrder(leaf->right);
			cout << leaf->value << ",";
		}
	}

public:
	BinaryTreeExample()
	{
		root = NULL;
	}
	~BinaryTreeExample()
	{
		destroyTree(root);
	}

	void destroyTree()
	{
		destroyTree(root);
	}
	void insertKey(int key)
	{
		if (root != NULL)
		{
			insertKey(key, root);
		}
		else
		{
			root = new node;
			root->value = key;
			root->left = NULL;
			root->right = NULL;
		}
	}
	node* search(int key)
	{
		return search(key, root);
	}

	void printInOrder()
	{
		printInOrder(root);
		cout << endl;
	}
	void printPreOrder()
	{
		printPreOrder(root);
		cout << endl;
	}
	void printPostOrder()
	{
		printPostOrder(root);
		cout << endl;
	}
};

class BinaryTreeAPI
{
public:
	int execute()
	{
		BinaryTreeExample *tree = new BinaryTreeExample();
		tree->insertKey(10);
		tree->insertKey(6);
		tree->insertKey(14);
		tree->insertKey(5);
		tree->insertKey(8);
		tree->insertKey(11);
		tree->insertKey(18);

		tree->printPreOrder();
		tree->printInOrder();
		tree->printPostOrder();

		delete tree;
		return 0;
	}
};