//most recent contribution 07/04/2019
// 4/9 failed 

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
    //first, bubblesort arrays
    public static int getTotalX(List<int> a, List<int> b)
    {        
        int lenA = a.Count;
        for(int i = 0;i<lenA;i++)
        {
            for(int j = 0; j<lenA-1;j++)
            {
                if(a[j]>a[j+1])
                {
                    int temp = a[j+1];
                    a[j+1]=a[j];
                    a[j]=temp;
                }
            }
        }

        int lenB = b.Count;
        for(int i = 0;i<lenB;i++)
        {
            for(int j = 0; j<lenB-1;j++)
            {
                if(b[j]>b[j+1])
                {
                    int temp = b[j+1];
                    b[j+1]=b[j];
                    b[j]=temp;
                }
            }
        }

        int accumA = 0;
        int accumB1 = 0;
        int accumB2 = 0;
        int accumB3 = 0;
        int prodA = 0;
        int prodDiv = 0;
        int prod = 0;
        int tmp = 0;
        int prod1 = 0;
        List<int> nums = new List<int>();
        //int prodA = 0;
        for(int k = 0; k<a.Count; k++)
        {
            if(a[a.Count-1] % a[k] ==0){}
            else{accumA +=1;}
        }
        if(accumA == 0)
        {
            for(int ii = a[a.Count-1]; ii <= b[0]; ii++)
            {
                if(b[0]%ii==0){accumB1 += 1;}                
            }
        }
            
        else if(accumA > 0)
        {                    
            for(int i = 0; i < a.Count-1; i++)
            {
               tmp = a[i] * a[i + 1];
               a[i+1] = tmp; 
            }                        
            prodA = a[a.Count-1];            
            if(prodA % 2 ==0)
            {                
                 prod = prodA/2;                   
            }
            else
            {
                prod = prodA;
            }
        
             for(int ii = prod; ii < b[0];)
            {
                if(b[0]%ii==0){accumB1 += 1;}
                ii += prod;
            }                   
        }        
         return accumB1;                                        
    }    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
