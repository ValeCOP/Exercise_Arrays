using System;
using System.Linq;
using System.Threading;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];         //Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr1 = new int[num];         //Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool reverse = true;

            for (int i = 0; i < num; i++)
            {
                int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (reverse)
                {
                    arr[i] = n[0];
                    arr1[i] = n[1];
                    reverse = false;
                }
                else
                {
                    arr[i] = n[1];
                    arr1[i] = n[0];
                    reverse = true;

                }

            }
            

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr1));


        }
    }
}
