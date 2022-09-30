using PersonalArrayMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_allAtOne01
{
    public class Task56
    {
        public static (int, int) FindMinRow(int[,] array)
        {
            int rowMin = 0;
            int sumRowResult = 0;
            int sumRowTemp = 0;
            for (int i = 0; i < array.GetLength(1); i++)
                sumRowResult = array[0, i] + sumRowResult;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumRowTemp = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumRowTemp = sumRowTemp + array[i, j];
                }

                if (sumRowResult > sumRowTemp) { sumRowResult = sumRowTemp; rowMin = i + 1; }
            }
            return (rowMin, sumRowResult);
        }

        public static int[,] Task56Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(56, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(56, "welcomtext");
            Console.Clear();
            Console.WriteLine(textTask);
            Console.WriteLine();
            Console.WriteLine(welcomtext);
            int maxValue = 10;
            int minValue = 0;
            int countDataValue = 2;
            do
            {
                var tuple = UserInterface.InsertUserDataDouble(countDataValue);
                if (tuple.Item1 == false) break;
                if (tuple.Item1 == true && tuple.Item2[0] >= 1 && tuple.Item2[1] >= 1)
                {
                    Console.WriteLine("Двумерный массив -> ");
                    int m = Convert.ToInt32(tuple.Item2[0]);
                    int n = Convert.ToInt32(tuple.Item2[1]);
                    int[,] array = ArrayGenerator.GetIntMatrix(m, n, minValue, maxValue);
                    int minRow = 0;
                    int row = 0;
                    ArrayPrinter.PrintMatrix(array);
                    (row, minRow) = (FindMinRow(array));
                    Console.WriteLine($"{row} строка, сумма {minRow}");
                    Console.WriteLine();
                    Console.WriteLine("Введите параметры для следующего массива(или quit для выхода): ");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(textTask);
                    Console.WriteLine();
                    Console.WriteLine(welcomtext);
                    Console.WriteLine("Введите параметры для следующего массива(или quit для выхода): ");
                }

            }
            while (true);

            int[,] result = new int[0, 0];

            return result;
        }
    }
}
