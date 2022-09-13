// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumNumbersOddPosition(int[] resGCEN)
{
    int result = 0;
    int i = 1;
    while (i < resGCEN.Length)
    {
        result = result + resGCEN[i];
        i+=2;
        
    }
    return result;
}

// int GetSumNumbersEvenPosition(int[] resGCEN)
// {
//     int result = 0;
//     int i = 0; 
//     while (i < resGCEN.Length)
//     {
//         result = result + resGCEN[i];
//         i+=2;
        
//     }
//     return result;
// }

string l_content =
@"*******************************************
* Программа создает массив заданой длины  *
* случайными числами и выводит  сумму     *
* элементов стоящих на нечетных позициях  *
*******************************************";
int minValueArr = 1, maxValueArr = 10;

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
Console.WriteLine($"Сумма чисел на не четных местах: {GetSumNumbersOddPosition(array1)}");
