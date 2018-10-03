using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Intro_to_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            bool IsOddEven = Convert.ToBoolean(N % 2);
            if (IsOddEven || N >=6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if(N >= 2 && N <=5 || N > 20)
            {
                Console.WriteLine("Not Weird");
            }

            Console.ReadLine();
        }
    }
}
