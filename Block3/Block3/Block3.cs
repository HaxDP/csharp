using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__FUGAS
{

    class Block3
    {
        static void Main()
        {
            //task 1
            /*
            Console.Write("Enter how much elements should be in massive: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int min = numbers[0];
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > min)
                {
                    min = number;
                }
                if (number < max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max element: " + min);
            Console.WriteLine("Min element: " + max);
            Console.ReadLine();
            
            //task 2
            /*
            Console.Write("Enter how much elements should be in massive: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int count = 0;

            foreach (int number in numbers)
            {
                if (number >= 0)
                {
                    sum += number;
                    count++;
                }
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("Avarage number is : " + average);
            }
            else
            {
                Console.WriteLine("In massive no positive numbers (unlucky).");
            }
            Console.ReadLine();
            */
            //task 3
            /*
            Console.Write("Enter how much elements should be in massive: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element: "); //Якщо там видає помилку, то знайте, шарпи хуйня, і там треба весь час ставити enter, тобто 1 enter 2 enter 3 enter і т.д.п.
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(numbers);
            Console.WriteLine("Reversed massive: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
            */
            //task 4
            /*
            Console.Write("Enter how much elements should be in massive: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = 1;
                }
            }
            Console.WriteLine("Massive with all machinations: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
            */
            //task 5
            /*
            Console.Write("Enter how much elements should be in massive: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Dictionary<int, int> ja_chas_yobnus = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (ja_chas_yobnus.ContainsKey(number))
                {
                    ja_chas_yobnus[number]++;
                }
                else
                {
                    ja_chas_yobnus[number] = 1;
                }
            }
            int mode = numbers[0];
            int maxumalne_blyat_Count = ja_chas_yobnus[mode];

            foreach (var pair in ja_chas_yobnus)
            {
                if (pair.Value > maxumalne_blyat_Count)
                {
                    maxumalne_blyat_Count = pair.Value;
                    mode = pair.Key;
                }
            }
            Console.WriteLine("Moda of massive: " + mode);
            Console.ReadLine();
            */
        }
    }
}
