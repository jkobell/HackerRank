//HackerRank
//Migratory Birds

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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        List<int> spec = new List<int>(){0,0,0,0,0};
        int tmp = 0;

        for(int i = 1; i<=5; i++)
        {
            for(int j = 0; j<arr.Count; j++)
            {
                if(arr[j]==i)
                {
                    spec[i-1]+=1;
                }
            }
        }
       
        for(int i = 1; i < spec.Count; i++)
        {
            if(spec[i]>spec[tmp])
            {
                tmp = i;
                
            }
        }     

        return tmp+1;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
