//HackerRank
//Counting Valleys

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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int vls = 0;
        int up = 0;
        int dn = 0;
       bool lv = true;

        foreach(char dir in s)
        {
            if(dir == 'U')//note: must use single quotes with a char
            {
                up += 1;                
            }
            else if(dir == 'D')
            {
                dn += -1;
            }
            else{};

            if(up + dn == 0)
            {
                up = 0;
                dn = 0;
                lv = true;
            }
            else if(up + dn < 0 && lv == true)
            {
                vls += 1;
                lv = false;               
            }
            else{};

        }
        

        return vls;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}