//Hackerrank Challenge: Grading Papers
//a grade of 38 or more will be returned
//qualifying grades are rounded up to the nearest 5 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        /*
         * Write your code here.
         */
         int len = grades.Length;
         int tmp = 0;
         for(int i = 0; i < len; i++)
         {
             tmp = grades[i] % 5;
             if(grades[i] < 38)
             { 
                 grades[i] = grades[i];          
            }
                    
            else
            { 
                if(tmp == 3)
                {
                    grades[i] = grades[i] + 2;
                }
                else if(tmp == 4)
                {
                    grades[i] = grades[i] + 1; 
                }
            }  
         }
         return grades;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
