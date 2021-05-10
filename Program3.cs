using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3Project
{
    class Program
    {
        public static void Main()
        {
            List<int> number = new List<int>();
        Console.WriteLine("Enter the numbers, if you want to quit enter a negative number");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i< 0)
                    break;
                else
                    number.Add(i);
            }
    IEnumerable<int> result = number.GroupBy(r => r).Where(r => r.Count() > 1).Select(r => r.Key);
    Console.WriteLine("The Repeated Numbers are:");
            foreach (var solution in result)
            {
                Console.WriteLine(solution);
            }
        }
    }
}
