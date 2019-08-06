//HackerRank
//BeautifulDays

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

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k) {
        int daysCount = 0;
        
        
        //string str = "";
        //string strRev = "";
        int last = 0;
        int rev = 0;
        int rem = 0;
        int diff = 0;

        for(int ii = i; ii <= j; ii++)
        {
            
            rem = ii;
            while(rem != 0)
            {
                last = rem%10;
                rev = (rev * 10) + last;
                rem = rem / 10;

            }
            
            diff = Math.Abs(ii - rev);
            last = 0;
            rev = 0;
            rem = 0;
            if(diff % k == 0)
            {
                daysCount += 1;
                
            }
            diff = 0;
        }        
        return daysCount;        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] ijk = Console.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);

        int j = Convert.ToInt32(ijk[1]);

        int k = Convert.ToInt32(ijk[2]);

        int result = beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
