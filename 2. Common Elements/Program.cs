using System;
using System.Linq;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            string[] arr1 = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr[i] == arr1[j])
                    {
                        Console.Write($"{arr[i]} ");
                    }
                }
            }


        }
    }
}
