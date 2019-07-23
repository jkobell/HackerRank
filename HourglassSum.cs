//HackerRank
//HourglassSum
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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {        
        int r2 = 1;        
        int sum = 0;
        int max = -64;
        int sets = arr.Length - 2;        
        int d1 = 0;
        int d2 = 0;

        for(int z = 0; z < sets; z++)
        {
            for(int i = sets; i > 0; i--)            
            {
                for(int j = d2, jj = 0; jj < 3; j++,jj++)
                {
                    sum += arr[d1][j];
                }
                sum += arr[d1+1][r2];
                for(int k = d2, kk = 0; kk<3; k++,kk++)
                {
                    sum += arr[d1+2][k];
                }
                d2++;
                r2++;
                if(sum > max)
                {
                    max = sum;                    
                }               
                sum = 0;          
            }
            d1++;
            d2 = 0;
            r2 = 1;           
        }
        return max;        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
