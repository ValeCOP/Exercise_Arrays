﻿using System;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[int.Parse(Console.ReadLine())];

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}