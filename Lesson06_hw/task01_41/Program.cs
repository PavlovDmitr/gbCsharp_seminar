// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

bool CheckInsert(bool[] check)
{
    for (int i = 0; i < check.Length; i++)
    {
        if (check[i] == false) { return false; }
    }
    return true;
}

int CalcPosNumbers(double[] numbers)
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
Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
bool[] checkParse = new bool[1];
double[] arrayDouble = new double[1];
char[] delimiterChar = { ' ', '.', '(', ')', '[', ']', '/'};
string[]? insArrayStrings = new string[1];
Console.WriteLine("Введите любое кол-во чисел через пробел:");

do
{
    string? insStr = Console.ReadLine().Trim(delimiterChar);
    insArrayStrings = insStr?.Split(delimiterChar);
    int len = insArrayStrings.Length;
    arrayDouble = new double[len];
    checkParse = new bool[len];
    
    for (int i = 0; i < len; i++)
    {
        checkParse[i] =  double.TryParse(insArrayStrings[i], out arrayDouble[i]);
    }
    
    if (CheckInsert(checkParse))
    {
        Console.WriteLine("Результат работы программы:");
        Console.WriteLine($"[{String.Join(", ",arrayDouble)}] -> {CalcPosNumbers(arrayDouble)} ");
    }
    else
    {
        Console.WriteLine($"Введите нормальные числа - для дробных чисел разделитель целой и дробной части в Windows запятая!");
    }
} while (!(CheckInsert(checkParse)));






