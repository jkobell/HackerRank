//HackerRank
//PickingNumbers

//Note: 1/10 Test Cases Failed

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

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        int max = 0;
        //int[] lst = new int[100];
        //return a.Count;
        int b10 = 0;
        int b11 = 0;
        int b12 = 0;        

        List<int> b1 = new List<int>();
        List<int> b2 = new List<int>();
        List<int> b3 = new List<int>();
        List<int> b4 = new List<int>();

        for(int i = 0; i < a.Count; i++)
        {
            for(int k = 0; k < a.Count; k++)
            {
                if(a[i] == a[k] || ((a[i] + 1)  == a[k]) || ((a[i] - 1) == a[k]))
                {                    
                    b1.Add(a[k]);
                }                
            }
            //return b1.Count;
            //return b1[0];
            b2 = b1.Distinct().ToList();
            b2.Sort();            

            if(b2.Count == 1)
            {
                //return b1.Count;
                //return b2[0];
                //return 99999;
                if(b1.Count > max)
                {
                    max = b1.Count;
                }         

            }
            else if(b2.Count == 2)
            {
                //return b1.Count;
                //return b2[0];
                
                if(b1.Count > max)
                {
                    max = b1.Count;
                }                
            }

            else if(b2.Count == 3)
            {
                //return b1.Count;
                //return b2[2];
                //return i;
                for(int j = 0; j < b1.Count; j++)
                {
                    if(b2[0] == b1[j]){b10++;}
                    else if(b2[1] == b1[j]){b11++;}
                    else if(b2[2] == b1[j]){b12++;}
                }
                //return b12;
                if(b10 > b11 && b10 > b12)
                {
                    b3.Add(b2[0]);
                    if(b11 > b12)
                    {
                        b3.Add(b2[1]);
                    }
                    else if(b12 > b11){b3.Add(b2[2]);}
                }
                else if(b11 > b10 && b11 > b12)
                {
                    b3.Add(b2[1]);
                    if(b10 > b12)
                    {
                        b3.Add(b1[0]);
                    }
                    else if(b12 > b10){b3.Add(b1[2]);}
                }
                else if(b12 > b10 && b12 > b11)
                {
                    b3.Add(b2[2]);
                    if(b10 > b11)
                    {
                        b3.Add(b1[0]);
                    }
                    else if(b11 > b10){b3.Add(b1[1]);}
                }
                else{}
                //return b3[0];
                if(b3.Count == 0)
                {
                    for(int ii = 0; ii < b1.Count; ii++)
                    {
                        if(b1[ii] == b2[0] || b1[ii] == b2[1])
                        {
                            b4.Add(b1[ii]);
                        }
                    }
                    if(b4.Count > max)
                    {
                        max = b4.Count;
                        //return b4.Count;
                    }              
                }

                /*
                else if(b3.Count == 1)
                {
                    for(int ii = 0;ii < b1.Count; ii++)
                    {
                        if(b1[ii] == b3[0] || b1[ii] == b2[2])
                        {
                           b4.Add(b1[ii]); 
                        }
                    }
                    if(b4.Count > max)
                    {
                        max = b4.Count;
                        //return b4.Count;
                    }              
                }
                */
                else if(b3.Count == 2)
                {
                    for(int ii = 0; ii < b1.Count; ii++)
                    {
                        if(b1[ii] == b3[0] || b1[ii] == b3[1])
                        {
                            b4.Add(b1[ii]);
                        }
                    }
                    if(b4.Count > max)
                    {
                        max = b4.Count;
                        //return b4.Count;
                    }                   
                }
                else
                {
                    //max = b2.Count;
                }
                           
            }
            

            b1.Clear();
            b2.Clear();
            b3.Clear();
            b4.Clear();            
            //cnt = -1;
        }

        return max;
        //return b1.Count;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
