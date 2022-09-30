using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalArrayMaster;

namespace task08_allAtOne01
{
    public class Task54
    {
        public static void PrintTask54(int[,] array)
        {
            //int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 5 } };
            int[] arrayOne = new int[array.GetLength(1)];
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                    arrayOne[i] = array[j, i];
                ArrayPrinter.PrintArray(ArrayMaster.SelectionSort(arrayOne, false));
            }
        }
        public static int[,] Task54Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(54, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(54, "welcomtext");
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
                    ArrayPrinter.PrintMatrix(array);
                    Console.WriteLine("Отсортированный двумерный массив -> ");
                    PrintTask54(array);
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

            int[,] result = new int[0,0];

            return result;
        }
    }
}
