using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09AllAtOne
{
    public class Task68
    {
        private static ulong Akkerman(ulong m, ulong n)
        {
            //if (m<0 || n<0) return 0;
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
            else if (m>0 && n> 0 ) return Akkerman(m-1, Akkerman(m,n-1));
            return Akkerman(m, n);
        }
        public static void Task68Solution()
        {
            string textTask = PersonalXmlReader.ReadNodeText(68, "text");
            string welcomtext = PersonalXmlReader.ReadNodeText(68, "welcomtext");
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
                    Console.Write($"A({tuple.Item2[0]},{tuple.Item2[1]}) ");
                    Console.Write($"-> {Akkerman(Convert.ToUInt64(tuple.Item2[0]), Convert.ToUInt64(tuple.Item2[1]))}");
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
