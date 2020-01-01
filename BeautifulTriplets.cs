//Beautiful Triplets
// 11/11 test cases

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

    // Complete the beautifulTriplets function below.
    static int beautifulTriplets(int d, int[] arr) {

        int beauti = 0;

        bool fullSet = false;
        
        int setCnt = 1;

        int setPnt = 0;

        for (int i = 0; i < arr.Length - 2; i++)
        {       
                
                for (int j = 0; j < arr.Length; j++)
                {                    
                       
                        
                            if ((arr[i] + d) == arr[j] && setCnt == 1)
                            {
                                setCnt++;                                
                            }
                            if ((arr[i] + (d*2)) == arr[j] && setCnt == 2)
                            {
                                setCnt++;                            
                           
                                beauti++;                                               
                            }                       
                                      
                }
                setCnt = 1;
                
        }

        return beauti;       

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = beautifulTriplets(d, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}