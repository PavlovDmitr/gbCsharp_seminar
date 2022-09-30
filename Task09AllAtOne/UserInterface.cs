using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09AllAtOne
{
    public class UserInterface
    {
        public static int GetSelectTask()
        {
            string taskList =
@$"1. {PersonalXmlReader.ReadNodeText(64, "shorttext").Remove(0,2)}
2. {PersonalXmlReader.ReadNodeText(66, "shorttext").Remove(0,2)}.
3. {PersonalXmlReader.ReadNodeText(68, "shorttext").Remove(0, 2)}
0. Выход.
";


            int result = 0;
            bool pass = false;
            do
            {
                Console.Clear();
                Console.WriteLine(taskList);
                Console.WriteLine("Выберите задание (1, 2, 3) или 0 (quit) для выхода");
                string insert = Console.ReadLine();
                if (insert.ToLower().Equals("quit") || insert.ToLower() == "exit") { result = 0; break; }
                else pass = int.TryParse(insert, out result);
            }
            while (!pass);
            return result;
        }
        public static (bool, double[]) InsertUserDataDouble()
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
        public static (bool, double[]) InsertUserDataDouble(int count)
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
                if (!CheckInsert(checkList) || numberList.Count < count)
                {
                    (int left, int top) = Console.GetCursorPosition();
                    Console.SetCursorPosition(left, top - 1);
                    Console.WriteLine("                                                                         ");
                    Console.SetCursorPosition(left, top - 2);
                    Console.WriteLine("                                                                         ");
                    Console.SetCursorPosition(left, top - 2);
                    Console.WriteLine($"Произвведите корректный ввод чисел (или quit для выхода)"); 
                }
            }
            while (!CheckInsert(checkList) || numberList.Count < count);
            if (insArrayStrings[0].ToLower() == "quit" || insArrayStrings[0].ToLower() == "exit") return (false, ConverListToArray(numberList));
            else return (true, ConverListToArray(numberList));
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
        static bool CheckInsert(List<bool> check)
        {
            for (int i = 0; i < check.Count; i++)
            {
                if (check[i] == false) { return false; }
            }
            return true;
        }
    }
}
