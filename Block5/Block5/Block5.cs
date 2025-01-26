using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__FUGAS
{
    class Block5
    {
        //task 1
        /*
        static void PrintMultiplicationTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        static void Main()
        {
            Console.Write("Enter number for multiplication table: ");
            int number = int.Parse(Console.ReadLine());
            PrintMultiplicationTable(number);
            Console.ReadLine();
        }
        */

        //task 2
        /*
        static void ConvertKilometersToMiles(int kilometers)
        {
            Console.WriteLine($"{kilometers} kilometers is equal to {kilometers * 0.62137119} miles");
        }
        static void Main()
        {
            Console.Write("Enter distance in kilometers to convert to miles: ");
            int kilometers = int.Parse(Console.ReadLine());
            ConvertKilometersToMiles(kilometers);
            Console.ReadLine();
        }
        */

        //task 3
        /*
        static int CalculatePower(int baseNumber, int exponent)
        {
            if (exponent == 0)
                return 1;

            int result = 1;
            for (int i = 0; i < Math.Abs(exponent); i++)
            {
                result *= baseNumber;
            }

            if (exponent < 0)
                throw new ArgumentException("Negative exponents are not supported for integer values.");

            return result;
        }
        static void Main()
        {
            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());
            int result = CalculatePower(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} raised to the power {exponent} = {result}");
            Console.ReadLine();
        }
        */

        //task 4
        /*
        static int CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");
            Console.ReadLine();
        }
        */

        //task 5
        /*
        static long CalculateFactorialRecursive(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            return number * CalculateFactorialRecursive(number - 1);
        }
        static void Main()
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());
            long factorial = CalculateFactorialRecursive(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");
            Console.ReadLine();
        }
        */
    }
}
