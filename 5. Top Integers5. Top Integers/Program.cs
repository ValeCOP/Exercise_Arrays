using System;
using System.Linq;
using System.Threading;

namespace _5._Top_Integers5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                                 Split(" ", StringSplitOptions.RemoveEmptyEntries).
                                 Select(int.Parse).
                                 ToArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                bool isBigger = true;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] <= arr[k])
                    {
                        isBigger = false;
                        break;
                    }
                    else
                    {
                        isBigger = true;
                    }
                    
          
                }
                if (isBigger)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
