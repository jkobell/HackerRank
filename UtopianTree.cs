//HackerRank
//UtopianTree

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

    // Complete the utopianTree function below.
    static int utopianTree(int n) {
        int hgt = 0;       

        if(n == 0){hgt = 1;}
        else if(n == 1){hgt = 2;}
        else if(n == 2) {hgt = 3;}
        else
        {
            hgt = 3;            
            int i = n-2;
            int j = n-2;
            while(i > 0)
            {
                if(j > 1)
                {
                    hgt = (hgt * 2);
                    i--;
                    hgt += 1;
                    i--;
                    j = j -2;
                }
                else if(j == 1)
                {
                    hgt = (hgt * 2);
                    i--;
                    j--;
                } 
            }
            
        }
        return hgt;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
