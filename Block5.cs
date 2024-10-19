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
        static void calc_task(int da)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{da} x {i} = {da * i}");
            }
        }
        static void main()
        {
            Console.Write("Enter number for multiply table: ");
            int da = int.Parse(Console.ReadLine());
            calc_task(da);
            Console.ReadLine();
        }
        */
        //task 2
        /*
        static void calc_task(int da)
        {
            Console.WriteLine($"{da} kilometers will be = {da * 0.62137119} miles");
        }
        static void Main()
        {
            Console.Write("Enter how many killometers, to convert in miles: ");
            int da = int.Parse(Console.ReadLine());
            calc_task(da);
            Console.ReadLine();
        }
        */
        //task 3
        /*
        static int calc_task(int num, int exp)
        {
            if (exp == 0)
                return 1;

            int result = 1;
            for (int i = 0; i < Math.Abs(exp); i++)
            {
                result *= num;
            }
            if (exp < 0)
                throw new ArgumentException("Negative powers are not supported for integer values.");
            return result;
        }
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter pow: ");
            int exp = int.Parse(Console.ReadLine());
            int result = calc_task(number, exp);
            Console.WriteLine($"{number} in pow {exp} = {result}");
            Console.ReadLine();
        }
        */
        //task 4
        /*
        static int calc_task(int nigger)
        {
            int res = 1;
            for(int i = 1; i < nigger+1; i++)
            {
                res *= i;
            }
            return res;
        }
        static void Main()
        {
            Console.Write("Enter number, to calculate factorial of it: ");
            int nigger = int.Parse(Console.ReadLine());
            int cell = calc_task(nigger);
            Console.WriteLine(cell);
            Console.ReadLine();
        }
        */
        //task 5
        /*
        static long cell(int nigger)
        {
            if (nigger == 0 || nigger == 1)
                return 1;
            return nigger * cell(nigger - 1);
        }
        static void Main()
        {
            Console.Write("Enter a number to calculate the factorial: ");
            int nigger = int.Parse(Console.ReadLine());
            long slay = cell(nigger);
            Console.WriteLine($"Factorial number {nigger} = {slay}");
            Console.ReadLine();
        }
        */
    }
}