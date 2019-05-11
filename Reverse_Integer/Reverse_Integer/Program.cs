using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    class Program
    {
        static int[] reverseArray(int[] a)
        {
            int arrLen = a.Length;
            int[] result = new int[arrLen];
            int j = arrLen - 1;
            for (int i = 0; i < arrLen; i++)
            {
                result[i] = a[j];
                j--;
            }
            return result;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to fill array.");

            string strRead = Console.ReadLine();
            char[] strArr = strRead.ToCharArray();
            int[] arr1 = strArr.Select(x => ((int)x) - '0').ToArray(); //subtracts 48 from the ASCII value of each

            int[] res = reverseArray(arr1);
            foreach (int pr in res)
            {
                Console.Write(pr);
            }
            Console.ReadKey();
        }
    }
}
