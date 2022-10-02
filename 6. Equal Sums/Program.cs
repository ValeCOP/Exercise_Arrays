using System;
using System.Linq;
using System.Net.WebSockets;

namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                                 Split(" ", StringSplitOptions.RemoveEmptyEntries).
                                 Select(int.Parse).
                                 ToArray();
            int leftSum = 0;
            int rightSum = 0;

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j]; 
                }
                for (int k = arr.Length-1; k > i; k--)
                {
                    rightSum += arr[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
               
            }
            if (rightSum != leftSum)
            {
                Console.WriteLine("no");
            }
            


        }
    }
}
