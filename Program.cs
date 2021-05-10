using System;

namespace Question2
{
    class Program
    {
        //Create a program that will take a min and a max value from user and print all the prime numbers between it
        static void Main(string[] args)
        {
            int a, b, i, j, flag;
            Console.WriteLine("Enter the minimum value: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the maximum value: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Prime numbers between " + "{0} and {1} are: ", a, b);

            for (i = a; i <= b; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
