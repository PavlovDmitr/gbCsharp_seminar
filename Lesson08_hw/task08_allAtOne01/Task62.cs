using PersonalArrayMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_allAtOne01
{
    public class Task62
    {
        public static int[,] Task62Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(62, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(62, "welcomtext");
            Console.Clear();
            Console.WriteLine(textTask);
            Console.WriteLine();
            Console.WriteLine(welcomtext);
            int maxValue = 16;
            int minValue = 0;
            do
            {
                var tuple = UserInterface.InsertUserDataDouble();
                if (tuple.Item1 == false) break;
                if (tuple.Item1 == true)
                {
                    int m=2; int n=2;
                    Console.WriteLine("Массив заполненый по спирали -> ");
                    if (tuple.Item2.Length == 2)
                    {
                        m = Convert.ToInt32(tuple.Item2[0]);
                        n = Convert.ToInt32(tuple.Item2[0]);
                        Console.WriteLine("Введено 1 число - квадратная матрица");
                    }
                    if (tuple.Item2.Length > 2)
                    {
                        m = Convert.ToInt32(tuple.Item2[0]);
                        n = Convert.ToInt32(tuple.Item2[1]);
                        Console.WriteLine("Введено 2 или больше чисел");
                    }
                    int[,] array = ArrayGenerator.GetIntMatrix(m, n, minValue, maxValue);
                    ArrayPrinter.PrintSpiralMatrix(array);
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
