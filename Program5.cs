using System;
using System.Collections.Generic;
using System.Text;

namespace Question5Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int ctr = 0;
            Console.WriteLine("Check username and password\n");

            do
            {
                Console.WriteLine("Please Enter the username: ");
                username = Console.ReadLine();

                Console.WriteLine("Please Enter the password: ");
                password = Console.ReadLine();

                if (username != "Admin" || password != "admin")
                {
                    Console.WriteLine("Incorrect username or password.Try again");
                    ctr++;
                }
                else
                    Console.WriteLine("Welcome");
                ctr = 1;
            }
            while ((username != "Admin" || password != "admin") && (ctr != 3));

            if (ctr == 3)
                Console.WriteLine("\nLogin attempt three or more times. Try later!");
            else
                Console.WriteLine("\nThe password entered successfully!");
        }
    }
}
