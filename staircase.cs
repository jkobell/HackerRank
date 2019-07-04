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

    // Complete the staircase function below.
    static void staircase(int n) {
        
        for(int i = 0; i < n; i++)
        {            
            int sp = n-i;
            Console.Write(String.Format("{0," + sp +"}", "#"));
            
            for(int j = 0; j<i; j++)
            {                
                Console.Write("#");                
            }
                Console.Write("\n");
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}