//between2sets
//6/21/2019 8:37 A.M.
//note: bubble sort the arrays

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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int a1 = 0;
        int a2 = 0;
        int b1 = 0;
        int b2 = 0;
        int accumA = 0;
        int accumB = 0;
        int tmp = 0;
        int cntrA = 0;
        bool aLst = true;
        bool bLst = true;
        int k = 0;

        List<int> lst = new List<int>();

         if(a.Count > 2)
            {            
                for(int i = 0; i < a.Count-1; i++)
                {
                    tmp = a[i] * a[i + 1];
                    a[i+1] = tmp; 
                }            
            accumA = a[a.Count-1];
            } 
            else if(a.Count == 2)
            {
                accumA = a[0] * a[1];
                //if((a[1] % a[0]) == 0){cntrA += 1;}
          
            }
            else 
            {
                accumA = a[0];
            }

            aLst = true;
            bLst = true;
            for(int i = 0; i < a.Count; i++)
            {
                if(accumA%a[i]!=0)
                {
                    aLst = false;
                }            
            }
            for(int i = 0; i < b.Count; i++)
            {
                if(b[i]%accumA !=0)
                {
                    bLst = false;
                } 
            }
            if(aLst == true && bLst == true)
            {
                lst.Add(accumA); 
            }


        for(int i = 0; i < a.Count; i++)
        {
            if(a[a.Count-1]%a[i]!=0)
            {
                aLst = false;
            }            
        }
        for(int i = 0; i < b.Count; i++)
        {
           if(b[i]%a[a.Count-1]!=0)
                {
                    bLst = false;
                } 
        }

        if(aLst == true && bLst == true)
        {
            lst.Add(a[a.Count-1]);            
        }

        aLst = true;
        bLst = true;
        k = b.Count-1;
        for(int i = 0; i < b.Count; i++)
        {
            if(b[k]%b[i]!=0)
            {
                bLst = false;
            }
        }
        if(bLst == true)
        {
            lst.Add(b[0]);
        }        

        return lst.Count;
        //return a[1];
        //return lst[0];
        //return b[k];
    }

----------------------
public static int getTotalX(List<int> a, List<int> b)
    {
        int a1 = 0;
        int a2 = 0;
        int b1 = 0;
        int b2 = 0;
        int accumA = 0;
        int accumB = 0;
        int tmp = 0;
        int cntrA = 0;

        if(a.Count > 2)
        {            
            for(int i = 0; i < a.Count-1; i++)
            {
               tmp = a[i] * a[i + 1];
               a[i+1] = tmp; 
            }            
            accumA = a[a.Count-1];
        } 
        else if(a.Count == 2)
        {
            if((a[1] % a[0]) == 0){cntrA += 1;}
            //if(4%2 == 0){cntrA += 11;}
        }
        else 
        {
            accumA = a[0];
        }

        return cntrA;
        //return a[1];
    }