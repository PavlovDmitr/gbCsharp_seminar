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
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{resPA[i]} ");
    }
    Console.WriteLine();
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


string l_content =
@"************************************************
* Программа создает массив заданой длины       *
* случайными числами и выводит разницу между   *
* максимальным и минимальным элементов массива *
************************************************";
int minValueArr = 1, maxValueArr = 10;
Console.Clear();
Console.WriteLine(l_content);
Console.WriteLine();
char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
string[] ins = new string[2];
double[] array1 = new double[1];
int baseA = 0;
bool checkNum1 = false;
do
{
    Console.WriteLine("Введите размер массива:");
    ins = Console.ReadLine().Split(delimiterChar);
    if (ins.Length < 1) continue;
    checkNum1 = int.TryParse(ins[0], out baseA);
}
while (!checkNum1);
array1 = GetArray(baseA, minValueArr, maxValueArr);
Console.WriteLine("Массив сгенерировался такой:");
PrintArray(array1);
array1 = GetRoundArr(array1);
Console.WriteLine("Массив после сокращения части знаков после запятой такой:");
PrintArray(array1);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {GetNumberMax(array1) - GetNumberMin(array1)}");