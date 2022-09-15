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
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write(i != size-1 ? $"{resPA[i]}, ": $"{resPA[i]}");
    }
    Console.Write("]");
}

int GetSumNumOddPositionArray(int[] resGCEN) //вот тут делема с наименованием))) что-то совсем длинное получилось.
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

string descriptionApp =
@"*******************************************
* Программа создает массив заданой длины  *
* случайными числами и выводит  сумму     *
* элементов стоящих на нечетных позициях, *
* нумерация элементов начинается с 0.     *
*******************************************";
int minValueArr = 1, maxValueArr = 10;

Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
string[] insArrayStrings = new string[2];
int[] arrayInt = new int[1];
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
arrayInt = GetArray(arrayLenght, minValueArr, maxValueArr);
Console.WriteLine($"Массив размерности {arrayLenght} и результат:");
PrintArray(arrayInt);
Console.WriteLine($" -> {GetSumNumOddPositionArray(arrayInt)}"); 