using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalArrayMaster
{
    public class ArrayPrinter
    {
        public static void PrintSpiralMatrix(int[,] matrix)
        {
            (int left, int top) = Console.GetCursorPosition();
            int n1 = matrix.GetLength(1);
            int n2 = matrix.GetLength(0);
            int dx = 0; int dy = 1;
            int x = 0; int y = 0;
            int nx; int ny;
            int n01 = 0; int n02 = 0;
            int k = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.SetCursorPosition(y*3+left, x*3 + top);
                Thread.Sleep(300);
                if (matrix[y, x]<10) Console.Write($"0{matrix[y, x]}");
                else Console.Write($"{matrix[y, x]}");
                nx = x + dx; ny = y + dy;
                if ((nx >= n01 && nx < n1) && (ny >= n02 && ny < n2))
                {
                   x = nx; y = ny;
                }
                else
                {
                    k++;
                    (dx, dy) = (dy, -dx);
                    x += dx; y += dy;
                    if (k == 3)
                    {
                        n01++;  n1--;
                    }
                    if (k==4)
                    {
                        n02++; n2--; k = 0;
                    }
                }
            }
            Console.SetCursorPosition(0, x*4 + top + matrix.GetLength(1)+2);
            
        }
        /// <summary>
        /// Печать одномерного массива в терминал
        /// </summary>
        /// <param name="resPA">массив вещественных чисел</param>
        /// <param name="arrSize">реальный размер массива</param>
        public static void PrintArray(double[] resPA, int arrSize)
        {
            int size = resPA.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write(size > arrSize ?
                    (i != size - 1 ? $"{resPA[i]},     " : $"{resPA[i]}     ") :
                    (i != size - 1 ? $"{resPA[i]}  |  " : $"{resPA[i]} "));
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Печать одномерного массива в терминал
        /// </summary>
        /// <param name="resPA">массив вещественных чисел</param>
        public static void PrintArray(double[] resPA)
        {
            int size = resPA.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write(i != size - 1 ? $"{resPA[i]} " : $"{resPA[i]} ");
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[] resPA)
        {
            int size = resPA.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write(i != size - 1 ? $"{resPA[i]}  " : $"{resPA[i]}  ");
            }
            Console.WriteLine();
        }
        public static void PrintMatrix(int[,] insMatrix)
        {
            for (int i = 0; i < insMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < insMatrix.GetLength(1); j++)
                {
                    Console.Write($"{insMatrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintMatrix(double[,] insMatrix)
        {
            for (int i = 0; i < insMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < insMatrix.GetLength(1); j++)
                {
                    Console.Write($"{insMatrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintArrayMean(int[,] matr)
        {
            int rowSum = 0;
            //int colSum = 0;
            double[] row = new double[matr.GetLength(1) + 1];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                rowSum = 0;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    row[j] = matr[i, j];
                    rowSum = rowSum + matr[i, j];
                }
                row[matr.GetLength(1)] = Math.Round(rowSum / Convert.ToDouble(matr.GetLength(1)), 2);
                PrintArray(row, row.Length - 1);
            }
            row = new double[matr.GetLength(1)];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    row[j] = row[j] + matr[i, j];
                }
            }
            for (int i = 0; i < row.Length; i++)
            {
                row[i] = Math.Round(row[i] / Convert.ToDouble(matr.GetLength(0)), 2);

            }
            PrintArray(row, row.Length);
        }

        public static void PrintThirdArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
