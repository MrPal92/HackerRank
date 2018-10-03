using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> PhoneBook = new Dictionary<string, decimal>();
            int NoOfEnteries = Convert.ToInt32(Console.ReadLine());
            string[] tempArr = new string[2];
            for (int i = 0; i < NoOfEnteries; i++)
            {
                tempArr = Console.ReadLine().Split(' ');
                PhoneBook.Add(tempArr[0],Convert.ToDecimal(tempArr[1]));
            }
            string query = "value";
            decimal result = 0;
            while (!String.IsNullOrEmpty(query))
            {
                query = Console.ReadLine();
                if (String.IsNullOrEmpty(query))
                {
                    break;
                }
                if (PhoneBook.TryGetValue(query, out result))
                    Console.WriteLine($"{query}={result}");
                else
                    Console.WriteLine("Not found");
            }
            Console.ReadLine();
        }
    }
}
