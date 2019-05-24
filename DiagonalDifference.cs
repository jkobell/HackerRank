//Hackerrank Challenge
//Name: Diagonal Difference
//a matrix of integers that are stored in a two-dimensional array 
//the difference of the diagonal sums must be returned as an absolute value
//an int is returned 

//the function
// Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr) {
        int elemLen = arr[0].Length;
        int accum1 = 0;
        int accum2 = 0;
        int sum = 0;
        int absol = 0;

        for(int i=0,j=0;i < elemLen; i++,j++ )
        {
            accum1 += arr[i][j];
        }

        for(int i = elemLen - 1, j = 0; i >= 0; i--,j++)
        {
            accum2 += arr[i][j];
        }

        sum = accum1 - accum2;
        if(sum < 0)
        {
            absol = sum * -1;
        }

        else
        {
            absol = sum;
        }
        return absol;

    }
	
// complete
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr) {
        int elemLen = arr[0].Length;
        int accum1 = 0;
        int accum2 = 0;
        int sum = 0;
        int absol = 0;

        for(int i=0,j=0;i < elemLen; i++,j++ )
        {
            accum1 += arr[i][j];
        }

        for(int i = elemLen - 1, j = 0; i >= 0; i--,j++)
        {
            accum2 += arr[i][j];
        }

        sum = accum1 - accum2;
        if(sum < 0)
        {
            absol = sum * -1;
        }

        else
        {
            absol = sum;
        }
        return absol;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
