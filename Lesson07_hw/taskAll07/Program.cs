// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using System;
using System.IO;

namespace taskAll07
{
    internal class Program
    {
        static void PrintArray(double[] resPA, int arrSize)
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

        static void PrintArrayMean(int[,] matr)
        {
            int rowSum = 0;
            int colSum = 0;
            double[] row = new double[matr.GetLength(1) + 1];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                rowSum = 0;
                colSum = 0;
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

        static bool CheckInsert(List<bool> check)
        {
            for (int i = 0; i < check.Count; i++)
            {
                if (check[i] == false) { return false; }
            }
            return true;
        }

        static double[] ConverListToArray(List<double> inslist)
        {
            int count = inslist.Count;
            double[] arr = new double[count + 1];
            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToDouble(inslist[i]);
            }
            return arr;
        }

        static double[,] GetDoubleMatrix(int m, int n, int minValue, int maxValue)
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

        static int[,] GetIntMatrix(int m, int n, int minValue, int maxValue)
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

        static void PrintMatrix(int[,] insMatrix)
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

        static void PrintMatrix(double[,] insMatrix)
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

        static int GetSelectTask()
        {
            string taskList = @"1. Задача 47. Задайте двумерный массив размером MxN, заполненный случайными вещественными числами.

2. Задача 50.  которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

0. Завершение работы программы";
            int result = 0;
            bool pass = false;
            do
            {
                Console.Clear();
                Console.WriteLine(taskList);
                Console.WriteLine("Выберите задание (1, 2, 3) или 0 для выхода");
                pass = int.TryParse(Console.ReadLine(), out result);
            }
            while (!pass);
            return result;
        }

        static (bool, double[]) InsertUserDataDouble()
        {
            char[] delimiterChar = { ' ', '.', '(', ')', '[', ']', '/', '!', '?', ';', ':' };
            string[]? insArrayStrings = new string[1];
            double[] arrayDouble = new double[1];
            bool checkParse = false;
            List<double> numberList = new List<double> { };
            List<bool> checkList = new List<bool> { };
            do
            {
                checkList.Clear();
                numberList.Clear();
                string? insStr = Console.ReadLine().Trim(delimiterChar);
                insArrayStrings = insStr?.Split(delimiterChar);
                if (insArrayStrings[0].ToLower().Equals("quit") || insArrayStrings[0].ToLower() == "exit") { break; }
                for (int i = 0; i < insArrayStrings.Length; i++)
                {
                    checkParse = double.TryParse(insArrayStrings[i], out double nextNum);
                    checkList.Add(checkParse);
                    numberList.Add(nextNum);
                }
                if (!CheckInsert(checkList)) Console.WriteLine($"Произвведите корректный ввод чисел (или quit для выхода)");
            }
            while (!CheckInsert(checkList));
            if (insArrayStrings[0].ToLower() == "quit" || insArrayStrings[0].ToLower() == "exit") return (false, ConverListToArray(numberList));
            else return (true, ConverListToArray(numberList));
        }
        static string[] GetTextDescriptionApp(string path)
        {

            if (!File.Exists(path))
            {
                Console.WriteLine("File text.md not found!");
                return new string[] { "отсутвует файл text.md", "отсутвует файл text.md", "отсутвует файл text.md", "отсутвует файл text.md", };
            }
            string[] readText = File.ReadAllLines(path);
            // Open the file to read from.
            // foreach (string s in readText)
            // {
            //     Console.WriteLine(s);
            // }

            return readText;
        }


        static void Main()

        {
            string path = @"info.md";

            string[] info = GetTextDescriptionApp(path);
            Console.WriteLine(info[1]);
            string descriptionApp1 =
@"************************************************
*  |0|1|2| m    Программа создает двумерный    *
*  |1|2|3|      массив вещественных чисел      *
*  |2|3|4|      Элементы массива со значениями *
*   n           от 0 до 10                     *
************************************************";
            string welcomText1 =
@"Введите размерность M x N массива через пробел. 
Будут взяты целые части введеных чисел.
Введите quit - для выхода из программы.";
            string descriptionApp2 =
@"************************************************
* |0|1|2| m  Программа создает двумерный массив *
* |1|2|3|   на вход принимает позиции возвращает*        
* |2|3|4|   значение этого элемента или же      *
*   n       указание, что такого элемента нет.  *
************************************************";
            string welcomText2 =
@"Введите позиции X и Y через пробел для проверки. 
Будут взяты целые части введеных чисел.
Введите quit - для выхода из программы.";
            string descriptionApp3 =
@"************************************************
* |0|1|2| m  Программа создает двумерный массив *
* |1|2|3|   и находит среднеарифметическое      *        
* |2|3|4|   значение каждой строки и столбца    *
*   n                                           *
************************************************";
            do
            {
                int select = GetSelectTask();
                if (select == 1)
                {
                    Console.Clear();
                    Console.WriteLine(descriptionApp1);
                    Console.WriteLine();
                    Console.WriteLine(welcomText1);
                    int maxValue = 10;
                    int minValue = 0;
                    do
                    {
                        var tuple = InsertUserDataDouble();
                        if (tuple.Item1 == false) break;
                        if (tuple.Item1 == true && tuple.Item2[0] >= 1 && tuple.Item2[1] >= 1)
                        {
                            Console.WriteLine("Двумерный массив -> ");
                            int m = Convert.ToInt32(tuple.Item2[0]);
                            int n = Convert.ToInt32(tuple.Item2[1]);
                            PrintMatrix(GetDoubleMatrix(m, n, minValue, maxValue));
                            Console.WriteLine("Введите параметры для следующего массива(или quit для выхода): ");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(descriptionApp1);
                            Console.WriteLine();
                            Console.WriteLine(welcomText1);
                            Console.WriteLine("Введите параметры для следующего массива(или quit для выхода): ");
                        }

                    }
                    while (true);
                }
                if (select == 2)
                {
                    Console.Clear();
                    Console.WriteLine(descriptionApp2);
                    Console.WriteLine();
                    Console.WriteLine(welcomText2);
                    int maxValue = 10;
                    int minValue = 0;
                    do
                    {
                        var tuple = InsertUserDataDouble();
                        if (tuple.Item1 == false) break;
                        if (tuple.Item1 == true && tuple.Item2[0] >= 1 && tuple.Item2[1] >= 1)
                        {
                            Console.WriteLine("Двумерный массив -> ");
                            int m = new Random().Next(2, 10);
                            int n = new Random().Next(2, 10);
                            int[,] matr = GetIntMatrix(m, n, minValue, maxValue);
                            PrintMatrix(matr);
                            int X = Convert.ToInt32(tuple.Item2[0]);
                            int Y = Convert.ToInt32(tuple.Item2[1]);
                            Console.WriteLine();
                            if (X < m && Y < n)
                            {
                                Console.WriteLine($"Элемент массива на позиции {X} {Y} - {matr[X, Y]}");
                            }
                            else Console.WriteLine($"Элемента массива на позиции {X} {Y} не существует");
                            Console.WriteLine("Введите параметры для следующего поиска в новом массиве(или quit для выхода): ");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(descriptionApp2);
                            Console.WriteLine();
                            Console.WriteLine(welcomText2);
                            Console.WriteLine("Введите параметры для следующего поиска в новом массиве(или quit для выхода): ");
                        }

                    }
                    while (true);
                }
                if (select == 3)
                {
                    Console.Clear();
                    Console.WriteLine(descriptionApp3);
                    Console.WriteLine();
                    int maxValue = 10;
                    int minValue = 0;
                    do
                    {
                        var tuple = InsertUserDataDouble();
                        if (tuple.Item1 == false) break;
                        if (tuple.Item1 == true && tuple.Item2[0] >= 1 && tuple.Item2[1] >= 1)
                        {
                            int m = Convert.ToInt32(tuple.Item2[0]);
                            int n = Convert.ToInt32(tuple.Item2[1]);
                            int[,] matr = GetIntMatrix(m, n, minValue, maxValue);
                            Console.WriteLine("Двумерный массив -> ");
                            PrintMatrix(matr);
                            Console.WriteLine("Двумерный массив c результатами -> ");
                            PrintArrayMean(matr);
                            Console.WriteLine("Введите параметры для следующего массива(или quit для выхода): ");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(descriptionApp3);
                            Console.WriteLine("Введите параметры для следующего массива(или quit для выхода): ");
                        }
                    }
                    while (true);
                }
                if (select == 0) break;
            }
            while (true);

        }

    }
}