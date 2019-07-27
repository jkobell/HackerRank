//HackerRank
//PDFviewer
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

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word) {
        int area = 0;
        int max = 0;
        char[] wrd = word.ToCharArray();
        string[] alpha = new string[26] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        Dictionary<string, int> abc = new Dictionary<string, int>();
        for(int i = 0; i < h.Length; i++)
        {
            abc.Add(alpha[i], h[i]);
        }

        foreach(KeyValuePair<string, int> ht in abc)
        {
            foreach(char ltr in wrd)
            {
                if(ltr.ToString() == ht.Key)
                {
                    if(ht.Value > max)
                    {
                        max = ht.Value;
                    }
                }
            }
        }
        area = wrd.Length * max;


        return area ;
        //return alpha.Length;
        //return abc["z"];
    }



    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
