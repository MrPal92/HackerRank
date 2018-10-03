using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Let_sReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfStrings = Convert.ToInt32(Console.ReadLine());
            if (noOfStrings >= 1 && noOfStrings <= 10)
            {
                string[] str = new string[noOfStrings];
                for (int i = 0; i < noOfStrings; i++)
                {
                    str[i] = Console.ReadLine();
                }

                for (int i = 0; i < str.Length; i++)
                {
                    PrintSeprateString(str[i]);
                }
            }
            Console.ReadKey();
        }

        static void PrintSeprateString(string str)
        {
            string odd = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(str[i]);
                else
                    odd = odd + str[i];
            }
            Console.Write(odd);
            Console.WriteLine();
        }
    }
}
