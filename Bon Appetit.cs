//HackerRank
//Bon Appetit

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

    // Complete the bonAppetit function below.
    static void bonAppetit(List<int> bill, int k, int b) {
        //if bill - k == b/2 ... print BA
        int sumB = 0;
        int diffB = 0;

        for(int i = 0; i < bill.Count; i++)
        {
            sumB += bill[i];
        }
        if((sumB - bill[k]) / 2 == b)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            diffB = b - ((sumB - bill[k]) / 2);
            Console.WriteLine(diffB.ToString());
        }

    }

    static void Main(string[] args) {
        string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
    }
}