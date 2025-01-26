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
            int maxElement = matrix[0, 0];
            int minElement = matrix[0, 0];
            int maxRow = 0, maxCol = 0;
            int minRow = 0, minCol = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }
            Console.WriteLine($"Max element: {maxElement} is in the row {maxRow + 1}, column {maxCol + 1}");
            Console.WriteLine($"Min element: {minElement} is in the row {minRow + 1}, column {minCol + 1}");
            Console.ReadLine();
            */
            //task 2
            /*
            Console.Write("Enter, how many rows in matrix: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter, how many columns in matrix: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] firstMatrix = new int[rows, cols];
            int[,] secondMatrix = new int[rows, cols];
            int[,] sumMatrix = new int[rows, cols];
            Console.WriteLine("Enter elements first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(sumMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //task 3
            /*
            Console.Write("Enter size of square matrix (n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] firstMatrix = new int[n, n];
            int[,] secondMatrix = new int[n, n];
            int[,] productMatrix = new int[n, n];
            Console.WriteLine("Enter elements first matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements second matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    productMatrix[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        productMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(productMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //task 4
            /*
            Console.Write("Enter size of square matrix (n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //task 5
            /*
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Enter matrix elements 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int determinant =
                (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +
                (matrix[0, 1] * matrix[1, 2] * matrix[2, 0]) +
                (matrix[0, 2] * matrix[1, 0] * matrix[2, 1]) -
                (matrix[0, 2] * matrix[1, 1] * matrix[2, 0]) -
                (matrix[0, 1] * matrix[1, 0] * matrix[2, 2]) -
                (matrix[0, 0] * matrix[1, 2] * matrix[2, 1]);
            Console.WriteLine($"Determinant 3x3: {determinant}");
            Console.ReadLine();
            */
        }
    }
}