//HackerRank
//Sock Merchant
//will use the Distinct() method to add unique values from array to a List

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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int[] color = new int[n];
        
        List<int> dst = new List<int>();
        int pair = 0;

        var dist = ar.Distinct();
        foreach(int val in dist)
        {
            dst.Add(val);
        }

        for(int ii = 0; ii<dst.Count; ii++)
        {
            for(int i = 0;i<ar.Length;i++)
            {
                if(dst[ii]==ar[i])
                {
                    color[ii]+=1;
                }

            }
        }

        for(int j = 0;j<color.Length;j++)
        {
            if(color[j]%2 == 0)
            {
                pair += color[j]/2;
            }
            else
            {
                pair += (color[j]-1)/2;
            }
        }
        return pair;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
