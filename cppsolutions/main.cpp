// main.cpp : This file contains the 'main' function. Program execution begins and ends there.

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file


#include <iostream>
#include "STL.cpp"
#include "DynamicArray.cpp"
#include "SparseArray.cpp"
#include "WaterBlockProblem.cpp"
#include "BalancedBrackets.cpp"
#include "MatrixMinimumCostPath.cpp"
#include "MergeSort.cpp"
#include "MatrixFindPeak.cpp"
#include "MaxDifferenceInArray.cpp"
#include "KLargestInArray.cpp"
#include "KaratsubaIntegerMultiplication.cpp"

using namespace std;

int main()
{

    // 1.STL
    STL stl;
    //stl.execute();

    // 2.Dynamic Array
    DynamicArray da;
    //da.execute();

    // 3.Sparse Array
    SparseArray sa;
    //sa.execute();

    // 4. Amazon Waterblock
    WaterBlockProblem wbp;
    //wbp.execute();

    // 5. Balanced Brackets
    BalancedBrackets bb;
    // bb.execute();

    // 6. Matrix Minimum Cost Path Finding
    MatrixMinimumCostPath mmcp;
    // mmcp.execute();

    // 7. Merge Sort
    MergeSort ms;
    // ms.execute();

    // 8. Matrix Find Peak
    MatrixFindPeak mfp;
    // mfp.execute();

    // 9. Max Diff in Array
    MaxDifferenceInArray mdia;
    // mdia.execute();

    // 10. K Largest In Array
    KLargestInArray klia;
    // klia.execute();

    // 11. Karatsuba Multiplication
    KaratsubaIntegerMultiplication kim;
    kim.execute();
}
