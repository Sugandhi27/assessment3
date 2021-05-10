using System;
using System.Linq;
using System.Collections.Generic;
namespace Question4Project
{
    class Question4
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers:");
            var List = new List<int>();
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                if (number > 0)
                    List.Add(number);
                number = Convert.ToInt32(Console.ReadLine());
            }

            List.Sort();
            foreach (var item in List)
            {
                Console.WriteLine("The numbers after sorting are:"+item);
            }
        }
    }
}
