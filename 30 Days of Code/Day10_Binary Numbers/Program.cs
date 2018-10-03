using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"binary is {binary}");

            int countConsectiveNo = 1;//max
            int tempcount = 1;
            for (int i = 0; i <= binary.Length - 1; i++)
            {
                if (binary[i] == '1' && binary[i + 1] == '1')
                {
                    tempcount++;
                }
                else
                {
                    if (tempcount > countConsectiveNo)
                    {
                        countConsectiveNo = tempcount;
                        tempcount = 1;
                    }
                    else
                    {
                        tempcount = 1;
                    }
                }
            }
            if (tempcount > countConsectiveNo)
            {
                countConsectiveNo = tempcount;
            }
            Console.WriteLine(countConsectiveNo);
            Console.ReadLine();
        }
    }
}
