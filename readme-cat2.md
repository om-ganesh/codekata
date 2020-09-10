# CATEGORY2: Problems
This section includes various problems from different online sources and real interview sessions

### **Dynamic Array**  
Issue:  
Definition: [From HackerRank](https://www.hackerrank.com/challenges/dynamic-array/problem)  
Solution: [DynamicArray.cs](csharpproject/DynamicArray.cs)  / [DynamicArray.cpp](cppsolutions/DynamicArray.cpp)  

### **Lower Bound STL**
Issue:  
Definition:  
```
Given N integers in sorted order and Q queries, with an integer in each query
Problem:  
If the given query integer is present in array, return the index. If multiple, return first one
If the given query integer is not present in array, return index at which the smallest integer that is greater than the given number is present  
Assumption: There will always be an answer for the query
```
Reference: [From HackerRank](https://www.hackerrank.com/challenges/cpp-lower-bound)  
Solution: [LowerBoundSTL.cs](csharpproject/LowerBoundSTL.cs)  / [STL.cpp](cppsolutions/STL.cpp)  

### **Block Storage**
Issue:  
Definition:  [Visual description](problems/AmznArray-WellContainerProblem.jpg)  
Solution: [AmznBlock.cs](csharpproject/AmznBlock.cs)  / [WaterBlockProblem.cpp](cppsolutions/WaterBlockProblem.cpp)  

### **Sparse Arrays**  
Issue:  
Definition: [From HackerRank](https://www.hackerrank.com/challenges/sparse-arrays/problem)  
Solution: [SparseArray.cs](csharpproject/SparseArray.cs)  / [SparseArray.cpp](cppsolutions/SparseArray.cpp)  

### **Balanced Bracket**
Issue:  
Definition: [From HackerRank](https://www.hackerrank.com/challenges/balanced-brackets/problem)  
Solution: [BalancedBrackets.cs](csharpproject/BalancedBrackets.cs)  / [BalancedBrackets.cpp](cppsolutions/BalancedBrackets.cpp)  

### **Minimum Cost Path Matrix**
Issue:  
Definition: [Visual description](problems/CodeJam-Matrix-MinimumPath.png)  
Solution: [MatrixMinimumCostPath.cpp](cppsolutions/MatrixMinimumCostPath.cpp)  

### **Karatsuba Multiplication**
Issue:  
Definition: [From HackerRank](https://www.geeksforgeeks.org/karatsuba-algorithm-for-fast-multiplication-using-divide-and-conquer-algorithm/)  
Solution: [IntegerMultiplication.cs](csharpproject/IntegerMultiplication.cs)  / [KaratsubaIntegerMultiplication.cpp](cppsolutions/KaratsubaIntegerMultiplication.cpp)   
Explanation: [Solution explained](problems/KaratsubaMultiplicationMethod.png)  

### **Maxmimum Difference in Array**
Issue:  
Definition: [From Geeksforgeeks](https://www.geeksforgeeks.org/maximum-difference-between-two-elements-in-an-array/)  
Solution: [MaxDiffInArray.cs](csharpproject/MaxDiffInArray.cs)  / [MaxDifferenceInArray.cpp](cppsolutions/MaxDifferenceInArray.cpp)  

### **Peak Finding in 1D Array**
Issue:  
Definition:   
```
For a array of numbers, find the peak, if it exists
Example [a,b,c,d,e,f,g,h,i]
Position 2 is peak iff b>=a and b>=c, in edge, only look on one side
```
Solution: [PeakFinding1d.cs](csharpproject/PeakFinding1d.cs)

### **Peak Finding in 2D Array**
Issue:  
Definition: [Visual description](problems/findpeak.png)  
Solution: [MatrixFindPeak.cpp](cppsolutions/MatrixFindPeak.cpp)  

### **Finding Kth largest element in Array**
Issue:  
Definition: Find the kth largest element in the array  
Solution: [KLargestInArray.cs](csharpproject/KLargestInArray.cs)  / [KLargestInArray.cpp](cppsolutions/KLargestInArray.cpp)  

### **Finding largest Range**
Issue:  
Definition:  
```
Given the array, find the largest range in the consecutive number sequence.  
Input: [1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6]  
Output: 7 (from 0 to 7 the range is 7 which is largest )
```
Solution: [ArrayRangeFind.cs](csharpproject/ArrayRangeFind.cs)   / [FindMaximumRange.cpp](cppsolutions/FindMaximumRange.cpp)

### **Magic Square Formation**
Issue:  
Definition: [From HackerRank](https://www.hackerrank.com/challenges/magic-square-forming/problem)  
Solution: [MagicSquareForming.cpp](cppsolutions/MagicSquareForming.cpp)  
  
Problem2 Definition:  
```
The sum in each row / col / diag for a matrix of size n is M, where M = n(n ^ 2 + 1) / 2
The first number(1) to be placed at position(n / 2, n - 1).Let this position be(i, j).
The next number(2) is placed at(i - 1, j + 1).If this position already has a number then place next number at(i + 1, j - 2).That is(i - 1 + 1, j + 1 - 2) = > (i, j - 1)
```
Solution: [MagicSquare.cpp](cppsolutions/MagicSquare.cpp)  

### **Boundary Checking**
Issue:  
Definition: Find if the given point falls inside the circular and rectangular space, as shown in [image](problems/boundary-check.png)  
Solution: [BoundaryCheck.cpp](cppsolutions/BoundaryCheck.cpp)  


### **Expression Evaluation**
Issue:  
Definition:  
```
expr = int | (operand expr+)
op = '+' | '*'
```
Solution: [ExpressionEvaluate.cpp](cppsolutions/ExpressionEvaluate.cpp)  

### **Largest Word in Dictionary**
Issue:  
Definition: [From Geeksforgeeks](https://practice.geeksforgeeks.org/problems/find-largest-word-in-dictionary/0)  
Solution: [FindLargestWordInDictionary.cpp](cppsolutions/FindLargestWordInDictionary.cpp)  

### **Subarray with given sum**
Issue:  
Definition: Find the first subarray that sums to a given sum.  
Reference: [From Geeksforgeeks](https://practice.geeksforgeeks.org/problems/subarray-with-given-sum/0)  
Solution: [GivenSumSubArray.cpp](cppsolutions/GivenSumSubArray.cpp)  

### **Finding Distinct number**
Issue:  
Definition:
```
You are given an array A containing 2*N+2 positive numbers, out of which 2*N numbers exist in pairs,
whereas the other two number occur exactly once and are distinct. 
You need to find the other two numbers and print them in ascending order
```
Reference: [from Geeksforgeeks](https://practice.geeksforgeeks.org/problems/finding-the-numbers/0)  
Solution: [FindDistinctNumbers.cpp](cppsolutions/FindDistinctNumbers.cpp) 

### **Jumping Number**
Issue:  
Definition: [from Geeksforgeeks](https://www.geeksforgeeks.org/print-all-jumping-numbers-smaller-than-or-equal-to-a-given-value/)  
Solution: [JumpingNumber.cpp](cppsolutions/JumpingNumber.cpp)  


### **Insert digit to find maximum Number**
Issue: https://github.com/om-ganesh/codekata/issues/29  
Definition:
```
Write a function that returns the maximum possible value obtained by inserting one digit inside the decimal number
Example: Given digit '5'
Given N = 276, function should return 5276
Given N = -999, function should return -5999
Given N = 0, function should return 50
Given N = 860, function should return 8650) 
```
Reference: [from Knowsh](https://www.knowsh.com/Notes/250501/Maximum-Possible-Value-By-Inserting-5)  
Solution: [FindMaximumNumber.cpp](cppsolutions/FindMaximumNumber.cpp)  
Discussion: [InsertDigit.png](problems/hint-getmaxinsertdigitbetweennumber.png.png)   
Source: FAANG 2020  

### **Maximum Profit with Stocks**
Issue: https://github.com/om-ganesh/codekata/issues/28  
Definition:  
```
Write an efficient function that takes stock_prices and returns the best profit I could have made from one purchase and one sale of one share of stock yesterday.
For, stock_prices = [10, 7, 5, 8, 11, 9]
get_max_profit(stock_prices)
Result = 6 (buying for $5 and selling for $11)  
```
Reference: [StockPrice](https://www.interviewcake.com/question/python/stock-price)  
Solution: [BestProfitStock.cs](csharpproject/BestProfitStock.cs)  / [StockPrice.cpp](cppsolutions/StockPrice.cpp)  

### **Find duplicate parenthesis**
Issue: https://github.com/om-ganesh/codekata/issues/19  
Definition:
```
Given a balanced expression that can contain opening and closing parenthesis, check if expression contains any duplicate parenthesis or not
Example:
Input: (a+b)+((c+d))
Output: YES

Input: ((a+b)+(c+d))
Output: NO
```
Reference: [Geeksforgeeks](https://www.geeksforgeeks.org/find-expression-duplicate-parenthesis-not/)
Solution: [FindDuplicateParenthesis.cs](csharpproject/FindDuplicateParenthesis.cs)

### **Split array into two equal sum subarrays**
Issue: https://github.com/om-ganesh/codekata/issues/46    
Definition:
```
You're given an array made up of positive integers. Split the given array into two smaller arrays where the sums of each smaller array are equal. 
Print out the index from where the left and right smaller arrays are equal.
Example:
[1,2,1,1,3] -> 2
[1,1,1,1,1,5] -> 4
[5,2,3] -> 0
[1, 2, 3, 4, 5, 5] -> 3
```
Reference: [From geeksforgeeks](https://www.geeksforgeeks.org/split-array-two-equal-sum-subarrays/)  
Solution: [SplitArray.cs](csharpproject/SplitArray.cs) 