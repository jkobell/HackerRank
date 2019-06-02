//HackerRank Min-Max Challenge
//1st, a bubble sort is used to sort the array
//2nd, the min sum is composed of sum of all array elements except for the last elements
//3rd, the max sum is composed of the sum of all array elements except for the first elements
//long [int64] is used as a sum variable to avoid exception caused by a number > int32
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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        int len = arr.Length;
        int temp = 0;
        long sum = 0;
        long summ = 0;
        for(int i = 0; i < len; i++)
        {
            for(int j = 0; j < len-1; j++)
            {
                if(arr[j]>arr[j+1])
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;                
                }
            }

        }

        for(int kk = len-2; kk>=0; kk--)
        {
            sum += arr[kk];
        }
        Console.Write(sum + " ");

        for(int k = 1; k<len; k++)
        {
            summ += arr[k];
        }
        Console.Write(summ);

    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}