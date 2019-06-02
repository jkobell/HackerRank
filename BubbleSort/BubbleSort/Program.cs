using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 9, 8, 2, 3, 7, 0, 6, 4, 5, 10, 15, 25, 35, 20, 55, 30, 45, 50, 40 };
            BubbleSort obj = new BubbleSort();
            obj.Sort(ints);
        }
    }

    public class BubbleSort
    {
        public void Sort(int[] intset)
        {
            int len = intset.Length;
            for(int i = 0; i < len; i++)
            {
                for(int j = 0; j < len - 1; j++)
                {
                    if(intset[j] > intset[j+1])
                    {
                        int temp = intset[j + 1];
                        intset[j+1] = intset[j];
                        intset[j] = temp;
                    }
                }
            }
            Console.WriteLine("The BubbleSort results of an array with " + len.ToString() + " elements:");
            foreach(int sorted in intset)
            {
                Console.Write(sorted.ToString() + " ");
                
            }
            Console.ReadKey();
        }
        
    }
}
