//HackerRank
//Mars Exploration
// 12/12 pass

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

    // Complete the marsExploration function below.
    static int marsExploration(string s) {
        char[] sos = new char[] {'S','O','S'};

        int inCount = s.Length;

        int max = 0;

        for (int i = 0; i < inCount; )
        {
            for (int j = 0; j < sos.Length; j++, i++)
            {
                if (sos[j] != s[i])
                {
                    max++;
                }
            }
        }

        return max;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}