//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool CheckInsert(List<bool> check)
{
    for (int i = 0; i < check.Count; i++)
    {
        if (check[i] == false) { return false; }
    }
    return true;
}

double[] ConvertListToArray(List<double> inslist)
{
    int count = inslist.Count;
    double[] arr = new double[count];
    for(int i= 0; i<count; i++)
    {
        arr[i] = Convert.ToDouble( inslist[i] );
    }
    return arr;
}

(bool, double[]) GetUserDataDouble()
{
    char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
    string[]? insArrayStrings = new string[1];
    double[] arrayDouble = new double[1];
    bool checkParse = false;
    int allCoefficientsCount = 4;
    List<double> numberList = new List<double> { };
    List<bool> checkList = new List<bool> { };
    do
    { 
    checkList.Clear();
    numberList.Clear();
    string? insStr = Console.ReadLine().Trim(delimiterChar);
    insArrayStrings = insStr?.Split(delimiterChar);
    if(insArrayStrings[0].ToLower().Equals("quit") || insArrayStrings[0].ToLower() == "exit") {break; }
    if(insArrayStrings[0].ToLower().Equals("")) 
        {
            Console.WriteLine($"Ошибка ввода, ввод необходимо начинать с числа");
        }
    for (int i = 0; i < insArrayStrings.Length; i++)
    {
        checkParse = double.TryParse(insArrayStrings[i], out double nextNum);
        checkList.Add(checkParse);
        numberList.Add(nextNum);
    }
    if (!CheckInsert(checkList)|| checkList.Count != allCoefficientsCount) Console.WriteLine($"Произвведите корректный ввод чисел (или quit для выхода)");
    }
    while (!CheckInsert(checkList) || checkList.Count != allCoefficientsCount);
    if (insArrayStrings[0].ToLower() == "quit" || insArrayStrings[0].ToLower() == "exit") return (false, ConvertListToArray(numberList));
    else return (true, ConvertListToArray(numberList));
}

(double, double) CalcCrossPoint(double[] userArray)
{   //y = k1 * x + b1, y = k2 * x + b2, x = (b1-b2)/(k2 - k1).
    double resultX = 0;
    double resultY = 0;
    resultX = (userArray[0] - userArray[2])/(userArray[3]-userArray[1]);
    resultY = (userArray[1]*resultX+userArray[0]);
    return (resultX, resultY);
}

string descriptionApp =
@"************************************************
* Программа находит точку пересечения двух     *
* прямых,заданных уравнениями                  *
* y = k1 * x + b1, y = k2 * x + b2             *
************************************************";
string welcomText = @"Введите значения b1, k1, b2, k2
quit - для выхода из программы.";

Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
Console.WriteLine(welcomText);

do
{
    var userData = GetUserDataDouble();
    if (userData.Item1 == false ) {break;}
    //if (userData.Item2[1] != userData.Item2[3]) 
    {
        var result = CalcCrossPoint(userData.Item2);
        Console.Write("Результат вычислений: ");
        Console.WriteLine($"[{String.Join(", ", userData.Item2)}] -> ({result.Item1}, {result.Item2})");
        Console.WriteLine("Введите следующую группу чисел(или quit для выхода): ");
    }
    //else Console.WriteLine(userData.Item2[0] == userData.Item2[2] ? $"введены параметры для одной прямой" : $"введены параметры для параллельных прямых");
}
while (true);