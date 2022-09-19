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

double[] ConverListToArray(List<double> inslist)
{
    int count = inslist.Count;
    double[] arr = new double[count+1];
    for(int i= 0; i<count; i++)
    {
        arr[i] = Convert.ToDouble( inslist[i] );
    }
    return arr;
}

(bool, double[]) InsertUserDataDouble()
{
    char[] delimiterChar = { ' ', '.', '(', ')', '[', ']', '/', '!', '?', ';',':'};
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
    if(insArrayStrings[0].ToLower().Equals("quit") || insArrayStrings[0].ToLower() == "exit") {break; }
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

string descriptionApp =
@"************************************************
* Программа производит подсчет кол-ва          *
* введнных пользователем положительных чисел   *
************************************************";
string welcomText = @"Введите числа через пробел для подсчета или
quit - для выхода из программы.";

Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
Console.WriteLine(welcomText);

do
{
    var tuple = InsertUserDataDouble();
    if (tuple.Item1 == false ) {break;}
    if (tuple.Item1 == true)
    {
        Console.Write("Кол-во введенных положительных чисел -> ");
        Console.WriteLine($"{CalcPosNumbers(tuple.Item2)} ");
        Console.WriteLine("Введите следующую группу чисел(или quit для выхода): ");
    }
}
while (true);