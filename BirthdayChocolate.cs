
//HackerRank
//Birthday Chocolate

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

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m) {
        int rtnFor = 0;
        int rtnRev = 0;
        int sCnt = s.Count;
        int[] sRev = new int[sCnt];

        for(int i=0,j=sCnt-1;i<sCnt;i++,j--)
        {
            sRev[i] = s[j];
        }
        
        if(s.Count > m)
        {
            for(int i = 0; i<sCnt-m;i++)
            {   
                int k = i;
                int accum = 0;
                for(int j = m; j>0;j--)
                {
                    accum += s[k];
                    k++; 
                }
                if(accum == d)
                {
                    rtnFor += 1;
                }
            }
            for(int i = 0; i<sCnt-m;i++)
            {   
                int k = i;
                int accum = 0;
                for(int j = m; j>0;j--)
                {
                    accum += sRev[k];
                    k++; 
                }
                if(accum == d)
                {
                    rtnRev += 1;
                }
            }
        }
        else
        {
            for(int i = 0; i<sCnt;i++)
            {
                int k = i;
                int accum = 0;
                for(int j = m; j>0;j--)
                {
                    accum += s[k];
                    k++; 
                }
                if(accum == d)
                {
                    rtnFor += 1;
                }
            }
            for(int i = 0; i<sCnt;i++)
            {
                int k = i;
                int accum = 0;
                for(int j = m; j>0;j--)
                {
                    accum += sRev[k];
                    k++; 
                }
                if(accum == d)
                {
                    rtnRev += 1;
                }
            }
        }
            
            if(rtnFor > rtnRev)
            {
                return rtnFor;
            }
            else
            {
                return rtnRev;
            }
                        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}




