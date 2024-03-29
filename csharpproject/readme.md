﻿# Online Problems (mostly from geeksofgeeks, leetcode, hackerrank, and more)
This section includes various problems from different online sources and real interview sessions

### **Dynamic Array**  
Definition: [HackerRank](https://www.hackerrank.com/challenges/dynamic-array/problem)  
Solution: [DynamicArray.cs](DynamicArray.cs)  / [DynamicArray.cpp](../cppsolutions/cppsolutions/DynamicArray.cpp)  

### **Lower Bound STL**
Definition: [HackerRank](https://www.hackerrank.com/challenges/cpp-lower-bound)  
Solution: [LowerBoundSTL.cs](LowerBoundSTL.cs)  / [STL.cpp](../cppsolutions/STL.cpp)  

### **Block Storage**
Definition:  [Visual description](../problems/AmznArray-WellContainerProblem.jpg)  
Solution: [AmznBlock.cs](AmznBlock.cs)  / [WaterBlockProblem.cpp](../cppsolutions/WaterBlockProblem.cpp)  

### **Sparse Arrays**  
Definition: [HackerRank](https://www.hackerrank.com/challenges/sparse-arrays/problem)  
Solution: [SparseArray.cs](SparseArray.cs)  / [SparseArray.cpp](../cppsolutions/SparseArray.cpp)  

### **Balanced Bracket**
Definition: [HackerRank](https://www.hackerrank.com/challenges/balanced-brackets/problem)  
Solution: [BalancedBrackets.cs](BalancedBrackets.cs)  / [BalancedBrackets.cpp](../cppsolutions/BalancedBrackets.cpp)  

### **Minimum Cost Path Matrix**
Definition: [Visual description](../problems/CodeJam-Matrix-MinimumPath.png)  
Solution: [MatrixMinimumCostPath.cpp](../cppsolutions/MatrixMinimumCostPath.cpp)  

### **Karatsuba Multiplication**
Definition: [Geeksforgeeks](https://www.geeksforgeeks.org/karatsuba-algorithm-for-fast-multiplication-using-divide-and-conquer-algorithm/)  
Solution: [KaratsubaMultiplication.cs](KaratsubaMultiplication.cs)  / [KaratsubaIntegerMultiplication.cpp](../cppsolutions/KaratsubaIntegerMultiplication.cpp)   
Discussion: [Solution explained](../problems/KaratsubaMultiplicationMethod.png)  

### **Maxmimum Difference in Array**
Definition: [Geeksforgeeks](https://www.geeksforgeeks.org/maximum-difference-between-two-elements-in-an-array/)  
Solution: [MaxDiffInArray.cs](MaxDiffInArray.cs)  / [MaxDifferenceInArray.cpp](../cppsolutions/MaxDifferenceInArray.cpp)  

### **Peak Finding in 1D Array**
Definition:   
```
For a array of numbers, find the peak, if it exists
Example [a,b,c,d,e,f,g,h,i]
Position 2 is peak iff b>=a and b>=c, in edge, only look on one side
```
Solution: [PeakFinding1d.cs](PeakFinding1d.cs)

### **Peak Finding in 2D Array**
Definition: [Visual description](../problems/findpeak.png)  
Solution: [MatrixFindPeak.cpp](../cppsolutions/MatrixFindPeak.cpp)  

### **Finding Kth largest element in Array**
Definition: [Leetcode](https://leetcode.com/problems/kth-largest-element-in-an-array/)
Solution: [KLargestInArray.cs](KLargestInArray.cs)  / [KLargestInArray.cpp](../cppsolutions/KLargestInArray.cpp)  

### **Finding largest Range**
Definition:  
```
Given the array, find the largest range in the consecutive number sequence.  
Input: [1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6]  
Output: 7 (from 0 to 7 the range is 7 which is largest ) 
```
Solution: [LargestConsecutiveRange.cs](LargestConsecutiveRange.cs)   / [FindMaximumRange.cpp](../cppsolutions/FindMaximumRange.cpp)

### **Magic Square Formation**
Definition: [HackerRank](https://www.hackerrank.com/challenges/magic-square-forming/problem)  
Solution: [MagicSquareForming.cpp](../cppsolutions/MagicSquareForming.cpp)  
TODO  
Problem2 Definition:  
```
The sum in each row / col / diag for a matrix of size n is M, where M = n(n ^ 2 + 1) / 2
The first number(1) to be placed at position(n / 2, n - 1).Let this position be(i, j).
The next number(2) is placed at(i - 1, j + 1).If this position already has a number then place next number at(i + 1, j - 2).That is(i - 1 + 1, j + 1 - 2) = > (i, j - 1)
```
Solution: [MagicSquareFormation.cs](MagicSquareFormation.cs) / [MagicSquare.cpp](../cppsolutions/MagicSquare.cpp)  

### **Boundary Checking**
Definition: Find if the given point falls inside the circular and rectangular space, as shown in [image](../problems/boundary-check.png)  
Solution: [BoundaryCheck.cpp](../cppsolutions/BoundaryCheck.cpp)  


### **Expression Evaluation**
Definition:  
```
expr = int | (operand expr+)
op = '+' | '*'
```
Solution: [ExpressionEvaluate.cpp](../cppsolutions/ExpressionEvaluate.cpp)  

### **Largest Word in Dictionary**
Definition: [Geeksforgeeks](https://practice.geeksforgeeks.org/problems/find-largest-word-in-dictionary/0)  
Solution: [LargestWordInDictionary.cs](LargestWordInDictionary.cs) / [FindLargestWordInDictionary.cpp](../cppsolutions/FindLargestWordInDictionary.cpp)  
TODO  

### **Subarray with given sum**
Definition: [Geeksforgeeks](https://practice.geeksforgeeks.org/problems/subarray-with-given-sum/0)  
Solution: [GivenSumSubArray.cs](GivenSumSubArray.cs) / [GivenSumSubArray.cpp](../cppsolutions/GivenSumSubArray.cpp)  

### **Finding Distinct number**
Definition: [Geeksforgeeks](https://practice.geeksforgeeks.org/problems/finding-the-numbers/0)  
Solution: [FindDistinctNumbers.cs](FindDistinctNumbers.cs) / [FindDistinctNumbers.cpp](../cppsolutions/FindDistinctNumbers.cpp) 

### **Jumping Number**
Definition: [Geeksforgeeks](https://www.geeksforgeeks.org/print-all-jumping-numbers-smaller-than-or-equal-to-a-given-value/)  
Solution: [JumpingNumbers.cs](JumpingNumbers.cs) / [JumpingNumber.cpp](../cppsolutions/JumpingNumber.cpp)  
TODO  

### **Maximum Profit with Stocks**
Issue: https://github.com/om-ganesh/codekata/issues/28  
Definition: [InterviewCake](https://www.interviewcake.com/question/python/stock-price)  
Solution: [StockPriceProfit.cs](StockPriceProfit.cs)  / [StockPrice.cpp](../cppsolutions/StockPrice.cpp)  

### **Find duplicate parenthesis**
Issue: https://github.com/om-ganesh/codekata/issues/19  
Definition: [Geeksforgeeks](https://www.geeksforgeeks.org/find-expression-duplicate-parenthesis-not/)  
Solution: [FindDuplicateParenthesis.cs](FindDuplicateParenthesis.cs)

### **Split array into two equal sum subarrays**
Issue: https://github.com/om-ganesh/codekata/issues/46    
Definition: [geeksforgeeks](https://www.geeksforgeeks.org/split-array-two-equal-sum-subarrays/)  
Solution: [TwoEqualSumSubarray.cs](TwoEqualSumSubarray.cs)   

### **Longest palindrome substring from the given string**
Issue: https://github.com/om-ganesh/codekata/issues/54    
Definition: [From geeksforgeeks](https://practice.geeksforgeeks.org/problems/longest-palindrome-in-a-string/0)  
Solution: [LongestPalindromeSubstring.cs](LongestPalindromeSubstring.cs) 

### **Rotate string in place by given offset**
Issue:    
Definition: [From lintcode](https://www.lintcode.com/problem/rotate-string/description)  
Solution: [RotateStringInplaceByOffset.cs](RotateStringInplaceByOffset.cs) 
