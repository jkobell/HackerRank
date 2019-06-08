//Hackerrank Challenge: Birthday Cake Candles
//function returns an integer with the number of maximum height candles
//Note: there is a time limit for runtime
//this function with two for loops passes all test cases 

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

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar) {
        int len = ar.Length;
        int max = 0;
        int accum = 0;
        for(int i = 0; i < len; i++)
        {
            if(ar[i] > max)
            {
                max = ar[i];
            }
            
        } 
        for(int k = 0; k < len; k++) 
        {
            if(ar[k] == max)
            accum += 1;
        }  
        return accum;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
