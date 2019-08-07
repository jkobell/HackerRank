//HackerRank
//FindDigits

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

    // Complete the findDigits function below.
    static int findDigits(int n) {
        int digs = 0;
        int tst = n;        
        int dig = 0;
        while(tst != 0)
        {
            dig = tst % 10;            
            tst = tst / 10;
            if(dig != 0)
            {
                if(n % dig == 0)
                {
                digs += 1;
                }
            }            
            dig = 0;
        }
        return digs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
