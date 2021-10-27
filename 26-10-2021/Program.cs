using System;

namespace _26_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Assignment-1
            //Console.WriteLine("Enter string: ");
            //string enterString = Console.ReadLine();

            //char chr;

            //Console.WriteLine("Enter char: ");
            //chr = Console.ReadLine()[0];


            //Console.WriteLine($"Index => {findCharIndex(enterString, chr)}");


            #endregion

            #region Assignment-2

            //Console.WriteLine("Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (findRoot(number) == (-1))
            //{
            //    Console.WriteLine("Bu ededin koku yoxdur!");
            //}

            //else
            //    Console.WriteLine(findRoot(number));

            #endregion

            #region Assignment-3
            //Console.WriteLine("Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(findTotal(number));
            #endregion

            #region Assignment-4
            //int[] numbers = { 1, 45, 87, 134, 98, 23, 745, 128, 456, 900, -1200, 589 };
            //if (numbers.Length != 0)
            //{
            //    Console.WriteLine(findMaxNumber(numbers));
            //}

            //else
            //    Console.WriteLine("Array bosdur!");
            #endregion

            #region Assignment-5
            //int[] numbers = { 1, 45, -87, 134, -98, 23, 745, 128, -456, 900, -1200, 589 };
            //foreach (int number in changePositiveNumber(numbers))
            //{
            //    Console.Write($"{number} ");
            //}
            #endregion
        }

        #region Assignment-1 Method
        static int findCharIndex(string text , char chr)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == chr)
                {
                    return i;
                }
            }

            return (-1);
        }
        #endregion

        #region Assignment-2 Method
        static int findRoot(int number)
        {

            for (int i = 0; i < number; i++)
            {
                if (i * i <= number)
                {
                    continue;
                }

                else
                    return (i - 1);
            }

            return (-1);
        }
        #endregion

        #region Assignment-3 Method
        static int findTotal(int num)
        {
            int total = 0;

            if (num < 0)
            {
                num = num * (-1);
            }


            while (num > 0)
            {
                int digit = num % 10;
                num = (num - digit) / 10;
                total += digit;

            }

            return total;

        }
        #endregion

        #region Assignment-4 Method
        static int findMaxNumber(int[] arr)
        {
            int max = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        #endregion

        #region Assignment-5 Method
        static int[] changePositiveNumber(int[] arr)
        {

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * (-1);
                }
            }

            return arr;
        }
        #endregion
    }
}
