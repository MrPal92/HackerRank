using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length == i + 1)
                {
                    Console.Write(arr[arr.Length - (i + 1)]);
                }
                else
                    Console.Write(arr[arr.Length - (i + 1)] + " ");
            }

            Console.ReadLine();
        }
    }
}
