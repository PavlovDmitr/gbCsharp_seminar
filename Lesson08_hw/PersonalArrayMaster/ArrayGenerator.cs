using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalArrayMaster
{
    public class ArrayGenerator
    {
        public static int[,] SpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            int dx = 0; int dy = 1;
            int x = 0; int y = 0;
            int nx; int ny;
            for (int i = 0; i < (n * n); i++)
            {
                matrix[x, y] = new Random().Next(1, 10);
                nx = x + dx; ny = y + dy;
                if ((nx >= 0 && nx < n) && (ny >= 0 & ny < n) && matrix[nx, ny] == 0)
                {
                    x = nx; y = ny;
                }
                else
                {
                    (dx, dy) = (dy, -dx);
                    x += dx;
                    y += dy;
                }
            }
            
            return matrix;
        }

        public static int[,] GetIntMatrix(int m, int n, int minValue, int maxValue)
        {
            int[,] result = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = new Random().Next(minValue, maxValue);
                }
            }
            return result;
        }
        public static double[,] GetDoubleMatrix(int m, int n, int minValue, int maxValue)
        {
            double[,] result = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
                }
            }
            return result;
        }
        /// <summary>
        /// Создание Трехмерного Массива 
        /// </summary>
        /// <param name="arX"></param>
        /// <param name="arY"></param>
        /// <param name="arZ"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int[,,] GetThirdArray(int arX, int arY, int arZ, int minValue, int maxValue)
        {
            int[,,] result = new int[arX, arY, arZ];
            for (int i = 0; i < arX; i++)
            {
                for (int j = 0; j < arY; j++)
                {
                    for (int k = 0; k < arZ; k++)
                    {
                        do
                            result[i, j, k] = new Random().Next(minValue, maxValue);
                        while (!CheckIncludeNum(result[i, j, k], result));
                    }
                }
            }
            return result;
        }
        static bool CheckIncludeNum(int num, int[,,] array)
        {
            bool result = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (num == array[i, j, k]) result = true;
                    }
                }
            }
            return result;
        }
    }
}
