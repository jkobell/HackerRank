//HackerRank
//ClimbingLeaderboard
//Note: 4/12 fail with timeout [6,7,8,9]

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

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        //List<int> rank = new List<int>();
        //List<int> dsct = new List<int>();

        int[] dsct = new int[scores.Length];
        int cntr = 0;
        bool rnk = false;

        //dsct = scores.Distinct().ToList(); 
        dsct = scores.Distinct().ToArray();
        int[] rank = new int[alice.Length];
        int rctr = 0;       

        for(int i = 0; i < alice.Length; i++)
        {
            rnk = false;
            for(int j = 0; j < dsct.Length; j++)                        
            {               
                if(alice[i] > dsct[j] || alice[i] == dsct[j])
                {
                    rnk = true;
                    cntr = j+1;
                    j = dsct.Length;                    
                }
                else{}                
            }
            if(rnk == false)
                {
                    //rank.Add(dsct.Length + 1);
                    rank[rctr] = dsct.Length + 1;
                    rctr++;
                }
            else if(rnk == true)
            {
                //rank.Add(cntr);
                rank[rctr] = cntr;
                rctr++;
            }
            else{}           
        }

        //return rank.ToArray(); 
        return rank;       
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}


// Note: iterating arrays in nested for loops has prevented timeout issue. 
// Also, advancing inner for loop counter
// 2/12 failing for logic issue, not timeout issue

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

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        
        int[] dsct = new int[scores.Length];
        int cntr = 0;       
        bool rnk = false;         
        dsct = scores.Distinct().ToArray();
        int[] rank = new int[alice.Length];
        int rctr = 0;
        int j = dsct.Length - 1;       

        for(int i = 0; i < alice.Length; i++)
        {
            rnk = false;
            
            while(j > 0)                        
            {                   
                if(alice[i] < dsct[j] || alice[i] == dsct[j])
                {
                    rnk = true;
                    cntr = j;
                    j = 0;                                    
                }                
                j--;                
            }
            
            if(rnk == true)
            {                
                if(alice[i] < dsct[cntr])
                {
                    rank[rctr] = cntr + 2;
                }
                else if(alice[i] == dsct[cntr])
                {
                    rank[rctr] = cntr + 1;
                }
                else{}
                
                rctr++;
                j = cntr;
                
            }
            else if(rnk == false)
            {
                rank[rctr] = 1;
                rctr++;
                
            }
            else{}           
        }

        //return rank.ToArray(); 
        return rank;
        //return dsct;       
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

