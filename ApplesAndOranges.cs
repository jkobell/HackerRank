//HackerRank Challenge
//Apples and Oranges

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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
            int lft1 = s - a;
            int lft2 = t - a;
            //int hsw = t - s;
            int rt1 = (b - t);
            int rt2 = (b - s);

            int m = 0;
            int n = 0;

            foreach(int dif in apples)
            {
                if(dif >= lft1 && dif <= lft2)
                {
                m += 1;
                }
            }

            foreach(int dif in oranges)
            {
                
                if((dif * -1) >= rt1 && (dif * -1) <= rt2)
                {
                n += 1;
                }
            }
            Console.WriteLine(m);
            Console.WriteLine(n);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
