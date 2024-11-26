using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__FUGAS
{
    class Block2
    {
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main()
        {
            //task1
            /*
            Console.Write("Enter height of piramid: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //task2
            /*
            Console.Write("Enter natural number N (1 ≤ N ≤ 100): ");
            int N = int.Parse(Console.ReadLine());

            if (N < 1 || N > 100)
            {
                Console.WriteLine("Error, the number must be in range 1 to 100");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                }

                Console.WriteLine("Sum of the fisrt {0} natural numbers, is: {1}", N, sum);
            }
            Console.ReadLine();
            */
            //task3
            /*
            Console.Write("Enter start of diapazone: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end of diapazone: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime number from {0} to {1}:", start, end);
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
            */
            //task4
            /*
            Console.Write("Enter integer number: ");
            int num = int.Parse(Console.ReadLine());

            int previousPrime = -1;
            for (int i = num - 1; i > 1; i--)
            {
                if (IsPrime(i))
                {
                    previousPrime = i;
                    break;
                }
            }

            if (previousPrime != -1)
            {
                Console.WriteLine("First prime number {0}: {1}", num, previousPrime);
            }
            else
            {
                Console.WriteLine("No prime numbers {0}.", num);
            }
            Console.ReadLine();
            */
            //task5
            /*
            Console.Write("Введіть число: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num != 0)
            {
                sum += Math.Abs(num % 10); 
                num /= 10; 
            }

            Console.WriteLine("Сума цифр числа: " + sum);
            */
        }
    }
}
