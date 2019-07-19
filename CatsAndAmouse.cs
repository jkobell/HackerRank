//HackerRank
//Cats and a Mouse

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

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z) {
        int catA = 0;
        int catB = 0;

        if(z > x)
        {
            catA = z - x;
        }
        else if(z < x)
        {
            catA = x - z;
        }
        else {catA = 0;}

        if(z > y)
        {
            catB = z - y;
        }
        else if(z < y)
        {
            catB = y -z;
        }
        else{catB = 0;}

        if(catA < catB)
        {
            return "Cat A";
        }
        else if(catA > catB)
        {
            return "Cat B";
        }
        else if(catA == catB)
        {
            return "Mouse C";
        }
        else {return "Test";}

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}