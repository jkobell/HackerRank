//Hackerrank Challenge
//Name: Compare the Triplets
//compares the elements of two List and 
//awards a score point to the higher int
//a list is returned 

// the function
static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            score.Add(0);
            score.Add(0);

            int elems = a.Count;
            for (int i = 0; i < elems; i++)
            {
                if(a[i] > b[i])
                {
                    score[0] += 1;
                }
                else if (a[i] < b[i])
                {
                    score[1] += 1;
                }

            }

            return score;
        }
		
		
//complete
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

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            score.Add(0);
            score.Add(0);
            int elems = a.Count;
            for (int i = 0; i < elems; i++)
            {
                if(a[i] > b[i])
                {
                    score[0] += 1;
                }
                else if (a[i] < b[i])
                {
                    score[1] += 1;
                }

            }

            return score;
        }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}