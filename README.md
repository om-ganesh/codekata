## CODEKATA - An ultimate guide to interview success
The repository is created to solve the fundamental interview questions, focussing on data structures and algorithms.  
This file maintains the details of each program and the related source/other information.
* The repository currently supports two languages: C++ and C#  
* IDE: Visual Studio 2019 (.net version 8.0)

# CATEGORY1: Algorithm Fundamentals
This section includes all the basic fundamental algorithms and the varieties of implementations

### **Binary Tree**
Definition: Implement methods Insert(), Search(), Delete()  
Solution: [BinaryTreeExample.cpp](cppsolutions/BinaryTreeExample.cpp)  


### **Merge Sorting**
Definition: Implement the merge sort [GeekforGeeks](https://www.geeksforgeeks.org/merge-sort/)  
Solution: [SortingMerge.cs](csharpproject/SortingMerge.cs)  / [MergeSort.cpp](cppsolutions/MergeSort.cpp) 


### **Stack**
Definition: Implement Stack  
Solution: [StackDataStructureByForwardList.cpp](cppsolutions/StackDataStructureByForwardList.cpp)  


### **Queue**
Definition: Implement Queue  
Solution: [QueueDataStructureByList.cpp](cppsolutions/QueueDataStructureByList.cpp)  


### **Graph Traversal**
Definition: Implement the searching algorithm for graph sort  
Solution: [GraphBFSAndDFS.cpp](cppsolutions/GraphBFSAndDFS.cpp)  


# CATEGORY2: Problems
This section includes various problems from different online sources and real interview sessions

### **Dynamic Array**  
Definition: [From HackerRank](https://www.hackerrank.com/challenges/dynamic-array/problem)  
Solution: [DynamicArray.cs](csharpproject/DynamicArray.cs)  / [DynamicArray.cpp](cppsolutions/DynamicArray.cpp)  

### **Lower Bound STL**
_Definition:_  
```
Given N integers in sorted order and Q queries, with an integer in each query
Problem:  
If the given query integer is present in array, return the index. If multiple, return first one
If the given query integer is not present in array, return index at which the smallest integer that is greater than the given number is present
```
Reference: [From HackerRank](https://www.hackerrank.com/challenges/cpp-lower-bound)  
Solution: [LowerBoundSTL.cs](csharpproject/LowerBoundSTL.cs)  / [STL.cpp](cppsolutions/STL.cpp)  

### **Block Storage**
Definition:  [Visual description](problems/AmznArray-WellContainerProblem.jpg)  
Solution: [AmznBlock.cs](csharpproject/AmznBlock.cs)  / [WaterBlockProblem.cpp](cppsolutions/WaterBlockProblem.cpp)  

### **Sparse Arrays**  
Definition: [From HackerRank](https://www.hackerrank.com/challenges/sparse-arrays/problem)  
Solution: [SparseArray.cs](csharpproject/SparseArray.cs)  / [SparseArray.cpp](cppsolutions/SparseArray.cpp)  

### **Balanced Bracket**
Definition: [From HackerRank](https://www.hackerrank.com/challenges/sparse-arrays/problem)  
Solution: [BalancedBrackets.cs](csharpproject/BalancedBrackets.cs)  / [BalancedBrackets.cpp](cppsolutions/BalancedBrackets.cpp)  

### **Minimum Cost Path Matrix**
Definition: [Visual description](problems/CodeJam-Matrix-MinimumPath.png)  
Solution: [MatrixMinimumCostPath.cpp](cppsolutions/MatrixMinimumCostPath.cpp)  

### **Karatsuba Multiplication**
Definition: [From HackerRank](https://www.geeksforgeeks.org/karatsuba-algorithm-for-fast-multiplication-using-divide-and-conquer-algorithm/)  
Solution: [IntegerMultiplication.cs](csharpproject/IntegerMultiplication.cs)  / [KaratsubaIntegerMultiplication.cpp](cppsolutions/KaratsubaIntegerMultiplication.cpp)   
Reference: [Solution explained](problems/KaratsubaMultiplicationMethod.png)  

### **Maxmimum Difference in Array**
Definition: TODO   
Solution: [MaxDiffInArray.cs](csharpproject/MaxDiffInArray.cs)  / [MaxDifferenceInArray.cpp](cppsolutions/MaxDifferenceInArray.cpp)  

### **Peak Finding in 1D Array**
_Definition:_   
```
For a array of numbers, find the peak, if it exists
Example [a,b,c,d,e,f,g,h,i]
Position 2 is peak iff b>=a and b>=c, in edge, only look on one side
```
Solution: [PeakFinding1d.cs](csharpproject/PeakFinding1d.cs)

### **Peak Finding in 2D Array**
Definition: [Visual description](problems/findpeak.png)  
Solution: [MatrixFindPeak.cpp](cppsolutions/MatrixFindPeak.cpp)  

### **Finding Kth largest element in Array**
Definition: Find the kth largest element in the array  
Solution: [KLargestInArray.cs](csharpproject/KLargestInArray.cs)  / [KLargestInArray.cpp](cppsolutions/KLargestInArray.cpp)  

### **Finding largest Range**
_Definition:_  
```
Given the array, find the largest range in the consecutive number sequence.  
Input: [1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6]  
Output: 7 (from 0 to 7 the range is 7 which is largest )
```
Solution: [ArrayRangeFind.cs](csharpproject/ArrayRangeFind.CS)  

### **Magic Square Formation**
Definition: [From HackerRank](https://www.hackerrank.com/challenges/magic-square-forming/problem)  
Solution: [MagicSquareForming.cpp](cppsolutions/MagicSquareForming.cpp)  

_Problem2 Definition:_
```
The sum in each row / col / diag for a matrix of size n is M, where M = n(n ^ 2 + 1) / 2
The first number(1) to be placed at position(n / 2, n - 1).Let this position be(i, j).
The next number(2) is placed at(i - 1, j + 1).If this position already has a number then place next number at(i + 1, j - 2).That is(i - 1 + 1, j + 1 - 2) = > (i, j - 1)
```
Solution: [MagicSquare.cpp](cppsolutions/MagicSquare.cpp)  

### **Boundary Checking**
Definition: TODO  
Solution: [BoundaryCheck.cpp](cppsolutions/BoundaryCheck.cpp)  


### **Expression Evaluation**
_Definition:_  
```
expr = int | (operand expr+)
op = '+' | '*'
```
Solution: [ExpressionEvaluate.cpp](cppsolutions/ExpressionEvaluate.cpp)  

### **Largest Word in Dictionary**
Definition: [From Geeksforgeeks](https://practice.geeksforgeeks.org/problems/find-largest-word-in-dictionary/0)  
Solution: [FindLargestWordInDictionary.cpp](cppsolutions/FindLargestWordInDictionary.cpp)  

### **Subarray with given sum**
Definition: [From Geeksforgeeks](https://practice.geeksforgeeks.org/problems/subarray-with-given-sum/0)  
Solution: [GivenSumSubArray.cpp](cppsolutions/GivenSumSubArray.cpp)  

### **Intersection of two arrays**
Definition: [From Leetcode](https://leetcode.com/problems/intersection-of-two-arrays/)  
Solution: Not implemented yet  

### **Find middle of given linked list**
_Definition:_
```
Given a singly linked list, find middle of the linked list. 
For example, if given linked list is 1->2->3->4->5 then 
output should be 3.
```
Reference: [From Geeksforgeeks](https://www.geeksforgeeks.org/write-a-c-function-to-print-the-middle-of-the-linked-list/)

### **Finding Distinct number**
_Definition:_
```
You are given an array A containing 2*N+2 positive numbers, out of which 2*N numbers exist in pairs,
whereas the other two number occur exactly once and are distinct. 
You need to find the other two numbers and print them in ascending order
```
Reference: [from Geeksforgeeks](https://practice.geeksforgeeks.org/problems/finding-the-numbers/0)  
Solution: [FindDistinctNumbers.cpp](cppsolutions/FindDistinctNumbers.cpp) 

### **Jumping Number**
Definition: TODO  
Solution: [JumpingNumber.cpp](cppsolutions/JumpingNumber.cpp)  

# CATEGORY3: Algorithms: 24-part Lecture Series
This section includes all the problems discussed from the book: Robert Sedgewick / Kevin Wayne  
Book Url: [Algorithms - 4th Edition](https://algs4.cs.princeton.edu/home/)  


### **ArrayTripletsSumToZero**
_Definition:_
```
Given N distinct integers, how many triples sum to exactly zero?    
```
Reference: [Chapter2](https://algs4.cs.princeton.edu/14analysis/)

### **Maximum Profit with Stocks**
_Definition:_
```
Write an efficient function that takes stock_prices and returns the best profit I could have made from one purchase and one sale of one share of stock yesterday.
For, stock_prices = [10, 7, 5, 8, 11, 9]
get_max_profit(stock_prices)
Result = 6 (buying for $5 and selling for $11)  
```
Reference: [StockPrice](https://www.interviewcake.com/question/python/stock-price)

