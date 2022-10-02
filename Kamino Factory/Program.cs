using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int sum = 0;
            int longestSequence = 1;
            int[] arrBest = new int[num];
            while (input != "Clone them!")
            {
                int[] arr = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int tempSequences = 1;
                int index = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    
                    if (arr[i] == arr[i + 1])
                    {
                        tempSequences++;
                        index = i;

                    }
                }




                input = Console.ReadLine();
            }



            Console.WriteLine($"Best DNA sample {index} with sum: {sum}.");
            Console.WriteLine($"{string.Join(" ", arrBest)}");
        }
    }
}
