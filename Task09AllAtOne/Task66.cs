using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09AllAtOne
{
    public class Task66
    {
        private static int CalcSum(int m, int n)
        {
            if (m > n) (m, n) = (n, m);
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static void Task66Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(66, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(66, "welcomtext");
            Console.Clear();
            Console.WriteLine(textTask);
            Console.WriteLine();
            Console.WriteLine(welcomtext);

            int countDataValue = 2;
            do
            {
                var tuple = UserInterface.InsertUserDataDouble(countDataValue);
                if (tuple.Item1 == false) break;
                if (tuple.Item1 == true)
                {
                    Console.Write($"Сумма чисел от {tuple.Item2[0]} до {tuple.Item2[1]}:" +
                        $" {CalcSum(Convert.ToInt32(tuple.Item2[0]), Convert.ToInt32(tuple.Item2[1]))}");
                    Console.WriteLine();
                    Console.WriteLine("Введите параметры для следующего расчета(или quit для выхода): ");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(textTask);
                    Console.WriteLine();
                    Console.WriteLine(welcomtext);
                    Console.WriteLine("Введите параметры для следующего расчета(или quit для выхода): ");
                }

            }
            while (true);
        }
    }
}
