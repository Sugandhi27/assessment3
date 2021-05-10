using System;

namespace Program7Project
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 4477468343113002;

            Console.Write(number + " is " +(isValid(number) ? "valid" : "invalid"));
        }

        public static bool isValid(long number)

        {

            return (getSize(number) >= 13 &&

                    getSize(number) <= 16) &&

                    (prefixMatched(number, 4) ||

                    prefixMatched(number, 5) ||

                    prefixMatched(number, 37) ||

                    prefixMatched(number, 6)) &&

                    ((sumOfDoubleEvenPlace(number) +

                    sumOfOddPlace(number)) % 10 == 0);

        }

        public static int sumOfDoubleEvenPlace(long number)

        {

            int sum = 0;

            String num = number + "";

            for (int i = getSize(number) - 2; i >= 0; i -= 2)

                sum += getDigit(int.Parse(num[i] + "") * 2);



            return sum;

        }

        public static int getDigit(int number)

        {

            if (number < 9)

                return number;

            return number / 10 + number % 10;

        }

        public static int sumOfOddPlace(long number)

        {

            int sum = 0;

            String num = number + "";

            for (int i = getSize(number) - 1; i >= 0; i -= 2)

                sum += int.Parse(num[i] + "");

            return sum;

        }

        public static bool prefixMatched(long number, int d)

        {

            return getPrefix(number, getSize(d)) == d;

        }
        public static int getSize(long d)

        {

            String num = d + "";

            return num.Length;

        }

        public static long getPrefix(long number, int k)

        {

            if (getSize(number) > k)

            {

                String num = number + "";

                return long.Parse(num.Substring(0, k));

            }

            return number;

        }
    }
}
