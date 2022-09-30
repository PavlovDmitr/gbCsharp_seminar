using PersonalArrayMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_allAtOne01
{
    public class Task58
    {
        static int[,] MatrixMultiplication(int[,] array1, int[,] array2)
        {
            int[,] result = new int[,] { { }, { } };
            int kSize = 0;
            int ar1X = array1.GetLength(0);
            int ar1Y = array1.GetLength(1);
            int ar2X = array2.GetLength(0);
            int ar2Y = array2.GetLength(1);
            
            if (ar1X == ar2Y)
            {
                kSize = ar1X;
                result = new int[ar1Y, ar2X];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        for (int k = 0; k < kSize; k++)
                            result[i, j] +=  array1[k, i] * array2[j, k];
                    }
                }
            }
            else if (ar1Y == ar2X)
            {
                kSize = ar1Y;
                result = new int[ar1X, ar2Y];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        for (int k = 0; k < kSize; k++)
                            result[i, j] += array1[i, k] * array2[k, j];
                    }
                }
            }
                        
            return result;
        }

        public static int[,] Task58Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(58, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(58, "welcomtext");
            Console.Clear();
            Console.WriteLine(textTask);
            Console.WriteLine();
            Console.WriteLine(welcomtext);
            int maxValue = 10;
            int minValue = 0;
            int countDataValue = 4;
            do
            {
                var tuple = UserInterface.InsertUserDataDouble(countDataValue);
                if (tuple.Item1 == false) break;
                if (tuple.Item1 == true && tuple.Item2.Length >= 4 && tuple.Item2[1] >= 1)
                {
                    
                    int[,] array1 = ArrayGenerator.GetIntMatrix
                        (Convert.ToInt32(tuple.Item2[0]), Convert.ToInt32(tuple.Item2[1]), minValue, maxValue);
                    int[,] array2 = ArrayGenerator.GetIntMatrix
                        (Convert.ToInt32(tuple.Item2[2]), Convert.ToInt32(tuple.Item2[3]), minValue, maxValue);
                    Console.WriteLine("Двумерный массив 1 -> ");
                    ArrayPrinter.PrintMatrix(array1);
                    Console.WriteLine();
                    Console.WriteLine("Двумерный массив 2 -> ");
                    ArrayPrinter.PrintMatrix(array2);
                    Console.WriteLine();

                    if (array1.GetLength(0) == array2.GetLength(1) || array1.GetLength(1) == array2.GetLength(0) )
                        
                    {
                        int[,] arraySQR = MatrixMultiplication(array1, array2);
                        ArrayPrinter.PrintMatrix(arraySQR);
                    }
                    else Console.WriteLine($"Матрицы не совместимы");
                    Console.WriteLine();
                    Console.WriteLine("Введите параметры для следующих массивов (или quit для выхода): ");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(textTask);
                    Console.WriteLine();
                    Console.WriteLine(welcomtext);
                    Console.WriteLine("Введите параметры для следующих массивов (или quit для выхода): ");
                }

            }
            while (true);

            int[,] result = new int[0, 0];

            return result;
        }

    }
}
