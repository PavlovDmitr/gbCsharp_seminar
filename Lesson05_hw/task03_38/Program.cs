// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() + new Random().Next(minValue,maxValue);
    }
    return res;
}

void PrintArray(double[] resPA)
{
    int size = resPA.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write(i != size-1 ? $"{resPA[i]}, ": $"{resPA[i]}");
    }
    Console.Write("]");
}

double[] GetRoundArr(double[] resGCEN)
{
    
    int i = 0;
    while (i < resGCEN.Length)
    {
        resGCEN[i] = Math.Round(resGCEN[i], 2);
        i++;
    }
    return resGCEN;
}

double GetNumberMin(double[] resGCEN)
{
    double result = 1;
    int i = 0;
    while (i < resGCEN.Length)
    {
        if (result > resGCEN[i])
            result = resGCEN[i];
        i++;
    }
    return result;
}

double GetNumberMax(double[] resGCEN)
{
    double result = 1;
    int i = 0;
    while (i < resGCEN.Length)
    {
        if (result < resGCEN[i])
            result = resGCEN[i];
        i++;
    }
    return result;
}


string descriptionApp =
@"************************************************
* Программа создает массив заданой длины       *
* случайными числами и выводит разницу между   *
* максимальным и минимальным элементов массива *
************************************************";
int minValueArr = 1, maxValueArr = 10;
Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
string[] insArrayStrings = new string[2];
double[] arrayDouble = new double[1];
int arrayLenght = 0;
bool checkParse = false;
do
{
    Console.WriteLine("Введите размер массива:");
    insArrayStrings = Console.ReadLine().Split(delimiterChar);
    if (insArrayStrings.Length < 1) continue;
    checkParse = int.TryParse(insArrayStrings[0], out arrayLenght);
}
while (!checkParse);
arrayDouble = GetArray(arrayLenght, minValueArr, maxValueArr);
Console.WriteLine("Массив сгенерировался такой:");
PrintArray(arrayDouble);
Console.WriteLine();
arrayDouble = GetRoundArr(arrayDouble);
Console.WriteLine("Массив после сокращения части знаков в элементах и результат работы программы:");
PrintArray(arrayDouble);
Console.WriteLine($"-> {Math.Round(GetNumberMax(arrayDouble) - GetNumberMin(arrayDouble),5)}");