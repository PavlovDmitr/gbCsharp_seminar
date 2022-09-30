using PersonalArrayMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_allAtOne01
{
    public class Task60
    {
        public static int[,] Task60Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(60, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(60, "welcomtext");
            Console.Clear();
            Console.WriteLine(textTask);
            Console.WriteLine();
            Console.WriteLine(welcomtext);
            int maxValue = 100;
            int minValue = 10;
            do
            {
                var tuple = UserInterface.InsertUserDataDouble();
                if (tuple.Item1 == false) break;
                if (tuple.Item1 == true && tuple.Item2.Length >= 3 && tuple.Item2[1] >= 1)
                {
                    Console.WriteLine("Трехмерный массив -> ");
                    int m = Convert.ToInt32(tuple.Item2[0]);
                    int n = Convert.ToInt32(tuple.Item2[1]);
                    int k = Convert.ToInt32(tuple.Item2[2]);
                    int[,,] array = ArrayGenerator.GetThirdArray(m, n, k, minValue, maxValue);
                    ArrayPrinter.PrintThirdArray(array);
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
