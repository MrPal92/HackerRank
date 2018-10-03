using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Recursion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(factorial(n));
            //int result = factorial(n);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        static int factorial(int n)
        {
            int value = n;
            for (int i = n; i > 2; i--)
            {
                value = value * (i - 1);
            }
            return value;
        }
    }
}
