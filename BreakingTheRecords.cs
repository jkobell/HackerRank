//Hackerrank
//Breaking The Records

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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores) {
        int[] recs = new int[2];
        int arrLen = scores.Length;
        int tmpH = scores[0];
        int tmpL = scores[0];

        for(int i = 1; i < arrLen; i++)
        {
            if(scores[i]>tmpH)
            {
                tmpH = scores[i];
                recs[0] += 1;
            }
            if(scores[i]<tmpL)
            {
                tmpL = scores[i];
                recs[1] += 1;
            }
        }

        return recs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
