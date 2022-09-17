// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

bool CheckInsert(List<bool> check)
{
    for (int i = 0; i < check.Count; i++)
    {
        if (check[i] == false) { return false; }
    }
    return true;
}

int CalcPosNumbers(List<double> numbers)
{
    int result = 0;
    foreach (double number in numbers)
    {
        if (number > 0)
        result++;
    }
    return result;
}

string descriptionApp =
@"************************************************
* Программа производит подсчет кол-ва          *
* введнных пользователем положительных чисел   *
************************************************";
string welcomText = @"Введите новое число или
end  - для окончания ввода,
quit - для выхода из программы.";
// Console.Clear();
// Console.WriteLine(descriptionApp);
// Console.WriteLine();
char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
string[]? insArrayStrings = new string[1];
double[] arrayDouble = new double[1];
int arrayLenght = 0;
bool checkParse = false;
// do
// {
//     Console.Clear();
//     Console.WriteLine(descriptionApp);
//     Console.WriteLine();
//     Console.WriteLine(welcomText);
//     insArrayStrings = Console.ReadLine().Split(delimiterChar);
//     // if(insArrayStrings[0].ToLower() == "quit"|| insArrayStrings[0].ToLower() == "end") break;
//     if (insArrayStrings.Length < 1) continue;
//     for(int i=0; i<insArrayStrings.Length; i++)
//     checkParse = int.TryParse(insArrayStrings[i], out arrayDouble[i]);
// }
// while (!checkParse);
// // if(insArrayStrings[0].ToLower() == "quit") System.Environment.Exit(0);
// Console.ReadLine();

List<double> numberList = new List<double> { };
List<bool> checkList = new List<bool> { };
Console.WriteLine("Введите любое кол-во чисел через пробел,");

do
{
    string? insStr = Console.ReadLine();
    insArrayStrings = insStr?.Split(delimiterChar);
    for (int i = 0; i < insArrayStrings?.Length; i++)
    {
        checkParse =  double.TryParse(insArrayStrings[i], out double nextNum);
        checkList.Add(checkParse);
        //Console.WriteLine(check[i]);
        numberList.Add(nextNum);
    }
    Console.WriteLine("Пробуем разобрать что написано...");
    if (CheckInsert(checkList))
    {
        Console.WriteLine($"{CalcPosNumbers(numberList)} ");

    }
    else
    {
        Console.WriteLine($"Введите нормальные числа - для дробных чисел разделитель целой и дробной части в Windows запятая!");
    }
} while (!(CheckInsert(checkList)));