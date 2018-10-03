using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }

        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = percentage(tip_percent) * meal_cost;
            double tax = percentage(tax_percent) * meal_cost;
            Console.WriteLine("The total meal cost is {0} dollars.", Convert.ToInt32(meal_cost + tip + tax));
            Console.ReadLine();
        }

        static double percentage(int per)
        {
            if (per == 0)
            {
                return 0.0;
            }
            else
            {
                return per / 100.00;
            }
        }
    }
}
