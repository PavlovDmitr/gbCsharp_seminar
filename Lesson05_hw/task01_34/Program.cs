// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] resPA)
{
    int size = resPA.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{resPA[i]} ");
    }
    Console.WriteLine();
}

int GetCountEvenNumbers(int[] resGCEN)
{
    int count = 0;
    for (int i = 0; i < resGCEN.Length; i++)
        if (resGCEN[i] % 2 == 0)
            count++;
    return count;
}

string l_content = @"Программа создает массив заданой длины 
случайными трехзначными числами и выводит
кол-во четных чисел в этом массиве";
int minValueArr = 100, maxValueArr = 999;

Console.Clear();
Console.WriteLine(l_content);
Console.WriteLine();
char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
string[] ins = new string[2];
int[] array1 = new int[1];
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
Console.WriteLine($"Кол-во четных чисел: {GetCountEvenNumbers(array1)}"); 


