using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int num = int.Parse(Console.ReadLine());

            
            for (int j = 0; j < num; j++)
            {
                int temp = n[0];
                for (int i = 0; i < n.Length - 1; i++)
                {
                    n[i] = n[i + 1];
                }
                n[n.Length - 1] = temp;

            }
            Console.WriteLine(String.Join(" ", n));
        }
    }
}
