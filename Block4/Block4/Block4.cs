using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__FUGAS
{
    class Block4
    {
        static void Main()
        {
            //task 1
            /*
            Console.Write("Enter, how many rows in matrix: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter, how many columns in matrix: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Element: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int ja_chas_yobnus_max = matrix[0, 0];
            int ja_chas_yobnus_min = matrix[0, 0];
            int maxRowwww = 0, maxColllllllllumn = 0;
            int minRowwww = 0, minColllllllllumn = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > ja_chas_yobnus_max)
                    {
                        ja_chas_yobnus_max = matrix[i, j];
                        maxRowwww = i;
                        maxColllllllllumn = j;
                    }
                    if (matrix[i, j] < ja_chas_yobnus_min)
                    {
                        ja_chas_yobnus_min = matrix[i, j];
                        minRowwww = i;
                        minColllllllllumn = j;
                    }
                }
            }
            Console.WriteLine($"Max element: {ja_chas_yobnus_max} is in the row {maxRowwww + 1}, column {maxColllllllllumn + 1}");
            Console.WriteLine($"Min element: {ja_chas_yobnus_min} is in the row {minRowwww + 1}, column {minColllllllllumn + 1}");
            Console.ReadLine();
            */
            //task 2
            /*
            Console.Write("Enter, how many rows in matrix: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter, how many columns in matrix: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] arc = new int[rows, cols];
            int[,] warden = new int[rows, cols];
            int[,] resultMatrixxx_pornhub_com = new int[rows, cols];
            Console.WriteLine("Enter elements first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    arc[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    warden[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrixxx_pornhub_com[i, j] = arc[i, j] + warden[i, j];
                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(resultMatrixxx_pornhub_com[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //task 3
            /*
            Console.Write("Enter size of square matrix (n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] arc = new int[n, n];
            int[,] warden = new int[n, n];
            int[,] resultMatrixxx_pornhub_com = new int[n, n];
            Console.WriteLine("Enter elements first matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    arc[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements second matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    warden[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultMatrixxx_pornhub_com[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        resultMatrixxx_pornhub_com[i, j] += arc[i, k] * warden[k, j];
                    }
                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(resultMatrixxx_pornhub_com[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //task 4
            /*
            Console.Write("Enter size of square matrix (n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] allahadbaaaaar = new int[n, n];
            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    allahadbaaaaar[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        allahadbaaaaar[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(allahadbaaaaar[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //task 5
            /*
            int[,] allahadbaaaaaar = new int[3, 3];
            Console.WriteLine("Enter matrix elements 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    allahadbaaaaaar[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int determinant_ya_zaraz_zaplachy =
                (allahadbaaaaaar[0, 0] * allahadbaaaaaar[1, 1] * allahadbaaaaaar[2, 2]) +
                (allahadbaaaaaar[0, 1] * allahadbaaaaaar[1, 2] * allahadbaaaaaar[2, 0]) +
                (allahadbaaaaaar[0, 2] * allahadbaaaaaar[1, 0] * allahadbaaaaaar[2, 1]) -
                (allahadbaaaaaar[0, 2] * allahadbaaaaaar[1, 1] * allahadbaaaaaar[2, 0]) -
                (allahadbaaaaaar[0, 1] * allahadbaaaaaar[1, 0] * allahadbaaaaaar[2, 2]) -
                (allahadbaaaaaar[0, 0] * allahadbaaaaaar[1, 2] * allahadbaaaaaar[2, 1]);
            Console.WriteLine($"Determinant 3x3: {determinant_ya_zaraz_zaplachy}");
            Console.ReadLine();
            */
        }
    }
}
