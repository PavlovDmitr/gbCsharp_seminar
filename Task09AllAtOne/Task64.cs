using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09AllAtOne
{
    public class Task64
    {
        private static int RecurFromNumToOne(int n)
        {
            if(n == 2) return 2;
            if (n%2 == 0) Console.Write($"{n} ");
            return RecurFromNumToOne(n - 1);
            
        }

        public static void Task64Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(64, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(64, "welcomtext");
            Console.Clear();
            Console.WriteLine(textTask);
            Console.WriteLine();
            Console.WriteLine(welcomtext);
            
            int countDataValue = 1;
            do
            {
                var tuple = UserInterface.InsertUserDataDouble(countDataValue);
                if (tuple.Item1 == false) break;
                if (tuple.Item1 == true)
                {
                    Console.Write($"Четные числа от {tuple.Item2[0]} до 1: ");
                    Console.Write($"{RecurFromNumToOne(Convert.ToInt32(tuple.Item2[0]))}");
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
