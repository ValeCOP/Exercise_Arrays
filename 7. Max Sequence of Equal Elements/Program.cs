using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                                 Split(" ", StringSplitOptions.RemoveEmptyEntries).
                                 Select(int.Parse).
                                 ToArray();
            int longestSequence = 1;
            int currNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int tempLongestSequence = 1;

                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (temp == arr[k])
                    {
                        tempLongestSequence++;
                        currNum = temp;
                    }
                    else
                    {
                        i = k - 1;
                        break;
                        
                    }
                    if (tempLongestSequence > longestSequence)
                    {
                        longestSequence = tempLongestSequence;
                        currNum = temp;
                    }
                }
            }
            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(currNum + " ");
            }

        }
    }
}
