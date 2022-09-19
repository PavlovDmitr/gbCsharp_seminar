//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool CheckInsert(bool[] check)
{
    for (int i = 0; i < check.Length; i++)
    {
        if (check[i] == false) { return false; }
    }
    return true;
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
* Программа найдёт точку пересечения двух      *
* прямых, заданных уравнениями                 *
* y = k1 * x + b1, y = k2 * x + b2             *
************************************************";
Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
bool[] checkParse = new bool[1];
double[] arrayDouble = new double[1];
char[] delimiterChar = { ' ', ';', '.', '(', ')', '[', ']', '/'};
string[]? insArrayStrings = new string[1];
Console.WriteLine("Введите значения b1, k1, b2 и k2 через пробел:");

do
{ 
    //string? insStr= insStr?.
    insArrayStrings = Console.ReadLine().Trim(delimiterChar).Split(delimiterChar);
    int len = insArrayStrings.Length;
    arrayDouble = new double[len];
    checkParse = new bool[len];
    
    for (int i = 0; i < len; i++)
    {
        checkParse[i] =  double.TryParse(insArrayStrings[i], out arrayDouble[i]);
    }
    
    if (CheckInsert(checkParse))
    {
        Console.WriteLine("Точка пересечения уравнений:");
        Console.WriteLine($"y = {arrayDouble[1]} * X + {arrayDouble[0]} , y = {arrayDouble[3]} * X + {arrayDouble[2]}");
        Console.WriteLine($" -> ({CalcCrossPoint(arrayDouble).Item1}, {CalcCrossPoint(arrayDouble).Item2}) ");
    }
    else
    {
        Console.WriteLine($"Введите нормальные числа - для дробных чисел разделитель целой и дробной части в Windows запятая!");
    }
} while (!(CheckInsert(checkParse)));