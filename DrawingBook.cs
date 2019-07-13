//HackerRank
// Drawing Book

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        int rtn = 0;

        if(n-p > p || n-p == p)
        {
            if(p%2==0 && p>1)
            {
                rtn = p/2;
            }
            else if(p==1)
            {
                rtn = p -1;
            }
            else
            {
                rtn = (p-1)/2;
            }            
        }
        else
        {
            if(n%2==0)
            {
                if(n-p == 1)
                {
                    rtn = 1;
                }
                else if(n-p == 0)
                {
                    rtn = 0;
                }
                else if((n-p)%2==0)
                {
                    rtn = (n-p)/2;
                }
                else 
                {
                    rtn = ((n-p)+1)/2;
                }
            }
            else
            {
                if(n-p == 0 || n-p == 1)
                {
                    rtn = 0;
                }
                else if((n-p)%2==0)
                {
                    rtn = (n-p)/2;
                }
                else
                {
                    rtn = ((n-p)-1)/2;
                }
            }
        }
        return rtn;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
