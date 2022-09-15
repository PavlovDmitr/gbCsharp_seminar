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
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write(i != size-1 ? $"{resPA[i]}, ": $"{resPA[i]}");
    }
    Console.Write("]");
}

int GetCountEvenNumbers(int[] resGCEN)
{
    int count = 0;
    for (int i = 0; i < resGCEN.Length; i++)
        if (resGCEN[i] % 2 == 0)
            count++;
    return count;
}

string descriptionApp = @"Программа создает массив заданой длины 
случайными трехзначными числами и выводит
кол-во четных чисел в этом массиве";
int minValueArr = 100, maxValueArr = 999;

Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
string[] arrayStrings = new string[2];
int[] arrayInt = new int[1];
int arrayLenght = 0;
bool checkParse = false;


do
{
    Console.WriteLine("Введите размер массива:");
    arrayStrings = Console.ReadLine().Split(delimiterChar);
    if (arrayStrings.Length < 1) {continue;};
    checkParse = int.TryParse(arrayStrings[0], out arrayLenght);
}
while (!checkParse);
arrayInt = GetArray(arrayLenght, minValueArr, maxValueArr);
Console.WriteLine($"Массив размерности {arrayLenght} и результат:");
PrintArray(arrayInt);
Console.WriteLine($" -> {GetCountEvenNumbers(arrayInt)}"); 


